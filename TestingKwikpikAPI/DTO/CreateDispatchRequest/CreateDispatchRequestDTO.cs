namespace TestingKwikpikAPI.DTO.CreateDispatchRequest
{

    public class CreateDispatchRequestDTO
    {
        public Result result { get; set; }

        public static implicit operator CreateDispatchRequestDTO(object v)
        {
            throw new NotImplementedException();
        }
    }

    public class Result
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
        public string currency { get; set; }
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
        public int weight { get; set; }
        public int quantity { get; set; }
        public string image { get; set; }
        public object value { get; set; }
    }

    public class Destination
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
    }

}
