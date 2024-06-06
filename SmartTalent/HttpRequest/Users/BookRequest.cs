namespace SmartTalent.HttpRequest.Users
{
    public class BookRequest
    {
        public int RoomId { get; set; }
        public List<Guest> Guests { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }
    }
}
