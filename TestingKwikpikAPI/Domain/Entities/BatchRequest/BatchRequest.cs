namespace TestingKwikpikAPI.Domain.Entities.BatchRequest
{
    public class BatchRequest
    {
        public Result result { get; set; }
    }

    public class Result
    {
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public Location location { get; set; }
        public Packagedetails packageDetails { get; set; }
        public string selectedVehicleType { get; set; }
        public string userType { get; set; }
        public Destination destination { get; set; }
        public string recipientPhoneNumber { get; set; }
        public string recipientName { get; set; }
        public string phoneNumber { get; set; }
        public string senderName { get; set; }
        public string recipientEmail { get; set; }
        public object currency { get; set; }
    }

    public class Location
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
    }

    public class Packagedetails
    {
        public string category { get; set; }
        public string product { get; set; }
        public string description { get; set; }
        public string weight { get; set; }
        public int quantity { get; set; }
        public string image { get; set; }
        public int value { get; set; }
    }

    public class Destination
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
    }

}
