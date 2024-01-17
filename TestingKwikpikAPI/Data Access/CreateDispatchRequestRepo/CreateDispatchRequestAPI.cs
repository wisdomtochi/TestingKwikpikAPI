using TestingKwikpikAPI.DTO.CreateDispatchRequest;

namespace TestingKwikpikAPI.Data_Access.CreateDispatchRequestRepo
{
    public class CreateDispatchRequestAPI : ICreateDispatchRequestAPI
    {
        private readonly HttpClient httpClient;

        public CreateDispatchRequestAPI(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Enum> CreateDispatchRequest(CreateDispatchRequestDTO dispatchRequestDTO)
        {

            throw new NotImplementedException();
            //try
            //{
            //    var payLoad = new
            //    {
            //        location = dispatchRequestDTO.result.data.location,
            //        package_details = dispatchRequestDTO.result.data.packageDetails,
            //        phone_number = dispatchRequestDTO.result.data.phoneNumber,
            //        recipient_name = dispatchRequestDTO.result.data.recipientName,
            //        recipient_phoneNumber = dispatchRequestDTO.result.data.recipientPhoneNumber,
            //        sender_name = dispatchRequestDTO.result.data.senderName,
            //        currency = dispatchRequestDTO.result.data.currency,
            //        selected_vehicle_type = dispatchRequestDTO.result.data.selectedVehicleType,
            //        destination = dispatchRequestDTO.result.data.destination,
            //        user_type = dispatchRequestDTO.result.data.userType
            //    };

            //    var baseUri = new Uri("https://dev-gateway.kwikpik.io/api/");
            //    var uri = new Uri(baseUri, "broker/init_request_ride/business");

            //    httpClient.BaseAddress = baseUri;
            //    httpClient.DefaultRequestHeaders.Accept.Clear();
            //    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc");

            //    var result = await httpClient.PostAsJsonAsync(uri, (object)payLoad);
            //    var response = await result.Content.ReadAsStringAsync();
            //    return Enums.DispatchRequestCreated;
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }
    }
}
