namespace SmartTalent.HttpRequest.Hotel
{
    public class HotelRequest
    {
        public string Name { get; set; }
        public bool Availability { get; set; }
        public int CityId { get; set; }
        public List<RoomRequest> Rooms { get; set; }
    }
}
