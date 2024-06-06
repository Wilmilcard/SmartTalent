namespace SmartTalent.HttpRequest.Users
{
    public class SearchBookingRequest
    {
        public string Code { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumGuest { get; set; }
        public int CityId { get; set; }
    }
}
