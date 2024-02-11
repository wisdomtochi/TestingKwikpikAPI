namespace TestingKwikpikAPI.Domain.Entities.Authenticate
{
    public class Authenticate
    {
        public Result result { get; set; }
    }

    public class Result
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
