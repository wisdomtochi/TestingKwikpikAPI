namespace TestingKwikpikAPI.DTO
{
    public class AuthenticateDTO
    {
        public result result { get; set; }
    }

    public class result
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public bool isVerified { get; set; }
        public string phoneNumber { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string token { get; set; }
    }

}
