using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartTalent.Domain.DB;
using SmartTalent.Domain.Models;
using SmartTalent.HttpRequest.Hotel;
using SmartTalent.Interfaces;
using SmartTalent.Utils;
using System.Diagnostics;

namespace SmartTalent.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("Policy")]
    [Authorize]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelServices _hotelService;
        private readonly IConfiguration Configuration;
        private readonly SmartTalentContext _context;

        public HotelController(IHotelServices hotelService, IConfiguration configuration, SmartTalentContext context)
        {
            _hotelService = hotelService;
            Configuration = configuration;
            _context = context;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetAllHotel()
        {
            try
            {
                var query = _hotelService
                    .QueryNoTracking()
                    .Select(x => new
                    {
                        x.HotelId,
                        x.Name,
                        x.Availability,
                        Rooms = _context.Rooms
                            .Where(r => r.HotelId == x.HotelId)
                            .Select(r => new
                            {
                                r.RoomId,
                                r.RoomNumber,
                                r.Availability
                            }).ToList(),
                        City = new
                        {
                            x.City.CityId,
                            x.City.Name
                        }
                    })
                    .ToList();

                var response = new
                {
                    success = true,
                    data = query,
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> GetHotelById([FromRoute] int id)
        {
            try
            {
                var query = _hotelService
                    .QueryNoTracking()
                    .Select(x => new
                    {
                        x.HotelId,
                        x.Name,
                        x.Availability,
                        Rooms = _context.Rooms
                            .Where(r => r.HotelId == x.HotelId)
                            .Select(r => new
                            {
                                r.RoomId,
                                r.RoomNumber,
                                r.Availability
                            }).ToList(),
                        City = new
                        {
                            x.City.CityId,
                            x.City.Name
                        }
                    })
                    .Where(x => x.HotelId == id)
                    .FirstOrDefault();

                var response = new
                {
                    success = true,
                    data = query,
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> CreateHotel([FromBody] HotelRequest request)
        {
            try
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    var claims = User.Claims.FirstOrDefault();
                    var person = _context.Persons.Include(x => x.User).Where(x => x.User.Username == claims.Value).FirstOrDefault();

                    if (person.RolTypeId == 2 || !person.User.IsAdmin)
                        return BadRequest(new { success = false, error = 401, content = "No esta autorizado registrar información de hoteles" });

                    if (string.IsNullOrEmpty(request.Name))
                        return new BadRequestObjectResult(new { success = false, data = "El campo nombre esta vacio" });
                    if (request.CityId <= 0)
                        return new BadRequestObjectResult(new { success = false, data = "No ha seleccionado ciudad" });

                    var departament = _hotelService.QueryNoTracking().Where(x => x.Name == request.Name).FirstOrDefault();
                    if (departament != null)
                        return new BadRequestObjectResult(new { success = false, data = "Ese hotel ya existe" });

                    var newHotel = new Hotel
                    {
                        Name = request.Name,
                        CityId = request.CityId,
                        CreatedAt = Globals.ActualDate(),
                        CreatedBy = person.User.Username
                    };

                    await _hotelService.AddAsync(newHotel);

                    foreach (var r in request.Rooms)
                    {
                        var addRoom = new Room
                        {
                            RoomNumber = r.RoomNumber,
                            Availability = r.Availability,
                            MaxGuest = r.MaxGuest,
                            HotelId = newHotel.HotelId,
                            RoomTypeId = r.RoomTypeId,
                            CreatedAt = Globals.ActualDate(),
                            CreatedBy = person.User.Username
                        };

                        _context.Rooms.Add(addRoom);
                    }

                    _context.SaveChanges();
                    transaction.Commit();
                }

                var response = new
                {
                    success = true
                };

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    data = new
                    {
                        success = false,
                        error = ex.Message,
                        errorCode = ex.HResult,
                        InnerError = ex.InnerException
                    }
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> UpdateRoomValues([FromBody] RoomValueRequest request)
        {
            try
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    var claims = User.Claims.FirstOrDefault();
                    var person = _context.Persons.Include(x => x.User).Where(x => x.User.Username == claims.Value).FirstOrDefault();

                    if (person.RolTypeId == 2 || !person.User.IsAdmin)
                        return BadRequest(new { success = false, error = 401, content = "No esta autorizado modificar valores en los tipos de habitación" });

                    var roomType = _context.RoomTypes.Where(x => x.RoomTypeId == request.RoomTypeId).FirstOrDefault();

                    if (roomType == null)
                        return new BadRequestObjectResult(new { success = false, data = "No existe ese Tipo de Habitación" });

                    roomType.ValuePerNight = request.Value;
                    roomType.UpdatedAt = Globals.ActualDate();
                    _context.RoomTypes.Update(roomType);

                    _context.SaveChanges();
                    transaction.Commit();
                }

                var response = new
                {
                    success = true
                };

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    data = new
                    {
                        success = false,
                        error = ex.Message,
                        errorCode = ex.HResult,
                        InnerError = ex.InnerException
                    }
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpPut("[Action]/{id}")]
        public async Task<IActionResult> UpdateHotel([FromBody] HotelRequest request, [FromRoute] int id)
        {
            try
            {
                using (var transaction = _context.Database.BeginTransaction())
                {

                    var claims = User.Claims.FirstOrDefault();
                    var person = _context.Persons.Include(x => x.User).Where(x => x.User.Username == claims.Value).FirstOrDefault();

                    if (person.RolTypeId == 2 || !person.User.IsAdmin)
                        return BadRequest(new { success = false, error = 401, content = "No esta autorizado registrar información de hoteles" });

                    var hotel = _hotelService.QueryNoTracking().Where(x => x.HotelId == id).FirstOrDefault();

                    if (hotel == null)
                        return new BadRequestObjectResult(new { success = false, data = "No existe el hotel" });

                    hotel.Name = request.Name;
                    hotel.CityId = request.CityId;
                    hotel.Availability = request.Availability;
                    hotel.UpdatedAt = Globals.ActualDate();
                    await _hotelService.UpdateAsync(hotel);

                    var all_rooms = _context.Rooms.Where(x => x.HotelId == id).ToList();
                    //Se verifica la disponibilidad de cada una de las habitaciones
                    //Pero si el Hotel no esta disponible, por consiguiente las habitaciones tampoco
                    foreach (var r in request.Rooms)
                    {
                        var room = all_rooms.Where(x => x.RoomId == r.RoomId).FirstOrDefault();
                        room.Availability = request.Availability ? r.Availability : request.Availability;
                        _context.Rooms.Update(room);
                    }

                    _context.SaveChanges();
                    transaction.Commit();
                }

                var response = new
                {
                    success = true
                };

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    data = new
                    {
                        success = false,
                        error = ex.Message,
                        errorCode = ex.HResult,
                        InnerError = ex.InnerException
                    }
                };
                return new BadRequestObjectResult(response);
            }
        }

    }
}
