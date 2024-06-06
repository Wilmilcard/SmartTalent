namespace SmartTalent.HttpRequest.Users
{
    public class Guest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public char Gender { get; set; }
        public int DocTypeId { get; set; }
        public string Document { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsPrincipalGuest { get; set; }
    }
}
