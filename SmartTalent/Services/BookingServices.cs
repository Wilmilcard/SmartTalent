using SmartTalent.Domain.Models;
using SmartTalent.Domain.Repository;
using SmartTalent.Interfaces;

namespace SmartTalent.Services
{
    public class BookingServices : BaseRepository<Booking>, IBookingServices
    {
        public BookingServices(IRepository<Booking> repository) : base(repository)
        {

        }
    }
}
