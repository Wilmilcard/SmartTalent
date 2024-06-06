using SmartTalent.Domain.Models;
using SmartTalent.Domain.Repository;
using SmartTalent.Interfaces;

namespace SmartTalent.Services
{
    public class HotelServices : BaseRepository<Hotel>, IHotelServices
    {
        public HotelServices(IRepository<Hotel> repository) : base(repository)
        {

        }
    }
}
