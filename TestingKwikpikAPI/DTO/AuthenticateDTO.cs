namespace TestingKwikpikAPI.DTO
{
    public class AuthenticateDTO
    {
        public AuthenticateProperties authenticateProperties { get; set; }
    }

    public class AuthenticateProperties
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
