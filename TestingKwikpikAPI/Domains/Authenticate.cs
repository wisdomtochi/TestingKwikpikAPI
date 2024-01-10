namespace TestingKwikpikAPI.Domains
{

    public class Authenticate
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
