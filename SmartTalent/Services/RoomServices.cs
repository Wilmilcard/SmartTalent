using SmartTalent.Domain.Models;
using SmartTalent.Domain.Repository;
using SmartTalent.Interfaces;

namespace SmartTalent.Services
{
    public class RoomServices : BaseRepository<Room>, IRoomServices
    {
        public RoomServices(IRepository<Room> repository) : base(repository)
        {

        }
    }
}
