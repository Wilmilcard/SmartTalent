using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartTalent.Domain.DB;
using SmartTalent.Interfaces;
using SmartTalent.Utils;

namespace SmartTalent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolsController : ControllerBase
    {
        private readonly IConfiguration Configuration;
        private readonly SmartTalentContext _context;

        public ToolsController(IConfiguration configuration, SmartTalentContext context)
        {
            Configuration = configuration;
            _context = context;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> FixValuesBooking()
        {
            try
            {
                var bookings = _context.Booking.AsNoTracking().ToList();

                foreach (var b in bookings)
                {
                    var room = _context.Rooms.Where(x => x.RoomId == b.RoomId).Include(x => x.RoomType).FirstOrDefault();
                    var days = b.EndDate.Day - b.StarDate.Day;
                    if (days <= 0)
                        days *= -1;
                    b.BaseCost = room.RoomType.ValuePerNight * days;
                    b.Tax = b.BaseCost * Globals.Tax();
                    b.Total = b.BaseCost + b.Tax;

                    _context.Booking.Update(b);
                    _context.SaveChanges();
                }

                var response = new
                {
                    success = true,
                    data = "Se actualizaron los valores",
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
