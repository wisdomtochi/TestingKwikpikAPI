namespace TestingKwikpikAPI.DTO.CreateDispatchRequest
{

    public class CreateDispatchRequestDTO
    {
        public string pickupAddress { get; set; }
        public string destinationAddress { get; set; }
        public string vehicleType { get; set; }
        public string userType { get; set; }
        public string recipientName { get; set; }
        public string recipientPhoneNumber { get; set; }
        public string phoneNumber { get; set; }
        public string category { get; set; }
        public string product { get; set; }
        public string description { get; set; }
        public string weight { get; set; }
        public int quantity { get; set; }
        public string packageValue { get; set; }
        public string image { get; set; }
        public string currency { get; set; }
        public string senderName { get; set; }
    }

}
