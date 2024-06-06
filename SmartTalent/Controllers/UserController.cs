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
        private readonly IConfiguration Configuration;
        private readonly SmartTalentContext _context;

        public UserController(IBookingServices bookingService, IConfiguration configuration, SmartTalentContext context)
        {
            _bookingService = bookingService;
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
                    .Where(x => 
                        x.StarDate >= request.StarDate
                        && x.EndDate >= request.EndDate
                        && x.TotalGuest == request.NumGuest
                        && x.Room.Hotel.City.CityId == request.CityId)
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

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetRooms([FromBody] RoomSearchRequest request)
        {
            try
            {
                if (request.HotelId <= 0)
                    return new BadRequestObjectResult(new { success = false, data = "No ha seleccionado un hotel" });
                if (request.CityId <= 0)
                    return new BadRequestObjectResult(new { success = false, data = "No ha seleccionado ciudad" });

                var query = _context.Rooms
                    .Include(x => x.Hotel)
                    .Where(x =>
                        x.HotelId == request.HotelId
                        && x.Hotel.CityId == request.CityId)
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

                var max_guest = _context.Rooms.Where(x => x.RoomId == request.RoomId).Select(x => x.MaxGuest).FirstOrDefault();
                if (request.Guests.Count > max_guest)
                    return new BadRequestObjectResult(new { success = false, data = "Supera la cantidad de huespedes que permite la habitación" });

                string _reservation;

                using (var transaction = _context.Database.BeginTransaction())
                {
                    var room = _context.Rooms.Where(x => x.RoomId == request.RoomId).FirstOrDefault();
                    var days = request.EndDate.Day - request.StarDate.Day;
                    if (days <= 0) days *= -1;

                    var _baseCost = room.RoomType.ValuePerNight * days;
                    var _tax = _baseCost * Globals.Tax();

                    var book = new Booking
                    {
                        StarDate = request.StarDate,
                        EndDate = request.EndDate,
                        Availability = false,
                        TotalGuest = request.Guests.Count,
                        BaseCost = _baseCost,
                        Tax = _baseCost * _tax,
                        Total = _baseCost + _tax,
                        RoomId = request.RoomId,
                        //PersonId = 
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
                            Console.WriteLine("");
                    }

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
