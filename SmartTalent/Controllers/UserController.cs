using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartTalent.Domain.DB;
using SmartTalent.Domain.Models;
using SmartTalent.HttpRequest.Users;
using SmartTalent.Interfaces;
using SmartTalent.Utils;

namespace SmartTalent.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("Policy")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IBookingServices _bookingService;
        private readonly IRoomServices _roomServices;
        private readonly IConfiguration Configuration;
        private readonly SmartTalentContext _context;

        public UserController(IBookingServices bookingService, IRoomServices roomServices, IConfiguration configuration, SmartTalentContext context)
        {
            _bookingService = bookingService;
            _roomServices = roomServices;
            Configuration = configuration;
            _context = context;
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> GetBooking([FromBody] SearchBookingRequest request)
        {
            try
            {
                var query = _bookingService.QueryNoTracking()
                    .Include(x => x.Room)
                        .ThenInclude(r => r.Hotel)
                            .ThenInclude(h => h.City)
                    .Include(x => x.Room)
                        .ThenInclude(r => r.RoomType)
                    .Include(x => x.Person)
                    .Where(x =>
                        x.Code == request.Code
                        || x.StarDate >= request.StarDate
                        || x.EndDate >= request.EndDate
                        || x.TotalGuest == request.NumGuest
                        || x.Room.Hotel.City.CityId == request.CityId)
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => new
                    {
                        x.Code,
                        ReservationBy = $"{x.Person.FirstName} {x.Person.LastName}",
                        x.Person.Document,
                        x.Room.Hotel.Name,
                        x.StarDate,
                        x.EndDate,
                        x.TotalGuest,
                        x.BaseCost,
                        x.Tax,
                        x.Total,
                        room = new
                        {
                            x.Room.RoomNumber,
                            x.Room.MaxGuest,
                            x.Room.RoomType.Name
                        },
                        x.Person.EmergencyContact,
                        x.Person.EmergencyPhone,
                        ReservationDate = x.CreatedAt
                    })
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
        public async Task<IActionResult> GetRooms([FromBody] RoomSearchRequest request)
        {
            try
            {
                if (request.HotelId <= 0)
                    return new BadRequestObjectResult(new { success = false, data = "No ha seleccionado un hotel" });
                if (request.CityId <= 0)
                    return new BadRequestObjectResult(new { success = false, data = "No ha seleccionado ciudad" });

                var query = _bookingService.QueryNoTracking()
                    .Include(x => x.Person)
                    .Include(x => x.Room)
                        .ThenInclude(r => r.Hotel)
                            .ThenInclude(h => h.City)
                    .Include(x => x.Room)
                        .ThenInclude(r => r.RoomType)
                    .Where(x =>
                        x.Room.HotelId == request.HotelId
                        || x.Room.Hotel.CityId == request.CityId)
                    .Select(x => new
                    {
                        x.Room.RoomNumber,
                        x.StarDate,
                        x.EndDate,
                        x.Room.Hotel.Name,
                        x.Room.MaxGuest,
                        x.Room.Availability,
                        RoomType = x.Room.RoomType.Name,
                        City = x.Room.Hotel.City.Name
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

        [HttpPost("[Action]")]
        public async Task<IActionResult> Book([FromBody] BookRequest request)
        {
            try
            {
                if (request.RoomId <= 0)
                    return new BadRequestObjectResult(new { success = false, data = "No ha seleccionado una habitacion" });
                if (request.StarDate >= request.EndDate || request.EndDate <= request.StarDate)
                    return new BadRequestObjectResult(new { success = false, data = "Hay un error al seleccionar las fechas" });

                var _room = _roomServices.QueryNoTracking().Where(x => x.RoomId == request.RoomId).Select(x => new { x.MaxGuest, x.Availability }).FirstOrDefault();
                if (request.Guests.Count > _room.MaxGuest)
                    return new BadRequestObjectResult(new { success = false, data = "Supera la cantidad de huespedes que permite la habitación" });
                if (!_room.Availability)
                    return new BadRequestObjectResult(new { success = false, data = "La habitación no esta disponible" });

                string _reservation;

                using (var transaction = _context.Database.BeginTransaction())
                {
                    var room = _roomServices.QueryNoTracking().Include(x => x.RoomType).Where(x => x.RoomId == request.RoomId).FirstOrDefault();
                    var days = request.EndDate.Day - request.StarDate.Day;
                    if (days <= 0) days *= -1;

                    var _baseCost = room.RoomType.ValuePerNight * days;
                    var _tax = _baseCost * Globals.Tax();

                    var rpta = false;
                    string _code;
                    do
                    {
                        _code = CodeGenerator.GenerateCode(6);
                        var code_in_db = _context.Booking
                            .Where(x => x.Code == _code)
                            .Select(x => x.Code)
                            .FirstOrDefault();

                        rpta = code_in_db == null;
                    } while (!rpta);

                    var book = new Booking
                    {
                        Code = _code,
                        StarDate = request.StarDate,
                        EndDate = request.EndDate,
                        Availability = false,
                        TotalGuest = request.Guests.Count,
                        BaseCost = _baseCost,
                        Tax = _baseCost * _tax,
                        Total = _baseCost + _tax,
                        RoomId = request.RoomId,
                        PersonId = 1,
                        CreatedAt = Globals.ActualDate(),
                        CreatedBy = Globals.UserSystem()
                    };
                    await _bookingService.AddAsync(book);
                    _reservation = book.Code;

                    foreach(var g in request.Guests)
                    {
                        var _guest = new Person
                        {
                            FirstName = g.FirstName,
                            LastName = g.LastName,
                            Birth = g.Birth,
                            Gender = g.Gender,
                            DocTypeId = g.DocTypeId,
                            Document = g.Document,
                            Email = g.Email,
                            Phone = g.Phone,
                            RolTypeId = 2,
                            EmergencyContact = request.EmergencyContact,
                            EmergencyPhone = request.EmergencyPhone,
                            CreatedAt = Globals.ActualDate(),
                            CreatedBy = Globals.UserSystem()
                        };

                        _context.Persons.Add(_guest);
                    }

                    foreach(var g in request.Guests)
                    {
                        if (g.IsPrincipalGuest)
                            EmailTools.SendEmails("", _reservation);
                    }

                    room.Availability = false;
                    room.UpdatedAt = Globals.ActualDate();
                    await _roomServices.UpdateAsync(room);

                    _context.SaveChanges();
                    transaction.Commit();
                }

                var response = new
                {
                    success = true,
                    data = new
                    {
                        Message = "Su reserva esta hecha con exito",
                        Tiket = $"Su numero de reserva es {_reservation}"
                    },
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
    }
}
