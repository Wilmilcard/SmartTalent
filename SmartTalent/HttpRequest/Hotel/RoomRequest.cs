namespace SmartTalent.HttpRequest.Hotel
{
    public class RoomRequest
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public bool Availability { get; set; }
        public int MaxGuest { get; set; }
        public int RoomTypeId { get; set; }
    }
}
