using System.Net.Http.Headers;
using TestingKwikpikAPI.DTO.CreateSingleRequest;
using TestingKwikpikAPI.Utility.Enums;

namespace TestingKwikpikAPI.Data_Access.CreateSingleRequestRepo
{
    public class CreateSingleRequestAPI : ICreateSingleRequestAPI
    {
        private readonly HttpClient httpClient;

        public CreateSingleRequestAPI(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> CreateSingleRequest(CreateSingleRequestDTO singleRequestDTO)
        {
            try
            {
                var payLoad = new
                {
                    location = singleRequestDTO.result.data.location,
                    package_details = singleRequestDTO.result.data.packageDetails,
                    phone_number = singleRequestDTO.result.data.phoneNumber,
                    recipient_name = singleRequestDTO.result.data.recipientName,
                    recipient_phoneNumber = singleRequestDTO.result.data.recipientPhoneNumber,
                    sender_name = singleRequestDTO.result.data.senderName,
                    currency = singleRequestDTO.result.data.currency,
                    selected_vehicle_type = singleRequestDTO.result.data.selectedVehicleType,
                    destination = singleRequestDTO.result.data.destination,
                    user_type = singleRequestDTO.result.data.userType,
                };

                var baseUri = new Uri("https://dev-gateway.kwikpik.io/api/");
                var uri = new Uri(baseUri, "broker/init_request_ride/business");

                httpClient.BaseAddress = baseUri;
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc");

                //var jsonContent = JsonContent.Create(payLoad);
                var result = await httpClient.PostAsJsonAsync(uri, payLoad);
                var response = await result.Content.ReadAsStringAsync();
                return EnumsImplementation.ConfirmationMessage(Enums.DispatchRequestCreated);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
