namespace TestingKwikpikAPI.DTO.GetDispatchRequest
{
    public class GetDispatchRequestDTO
    {
        public Result result { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string status { get; set; }
        public string userId { get; set; }
        public object riderId { get; set; }
        public bool isInTransit { get; set; }
        public bool isUserRated { get; set; }
        public bool isRiderRated { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public Location location { get; set; }
        public Packagedetails packageDetails { get; set; }
        public string selectedVehicleType { get; set; }
        public string userType { get; set; }
        public Destination destination { get; set; }
        public string recipientPhoneNumber { get; set; }
        public string recipientName { get; set; }
        public string phoneNumber { get; set; }
        public string senderName { get; set; }
        public string currency { get; set; }
        public float amount { get; set; }
    }

    public class Location
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string formattedAddress { get; set; }
    }

    public class Packagedetails
    {
        public string category { get; set; }
        public string product { get; set; }
        public string description { get; set; }
        public int weight { get; set; }
        public int quantity { get; set; }
        public string image { get; set; }
        public object value { get; set; }
    }

    public class Destination
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string formattedAddress { get; set; }
    }

}
