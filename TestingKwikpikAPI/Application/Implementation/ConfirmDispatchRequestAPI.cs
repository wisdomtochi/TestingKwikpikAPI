using System.Net.Http.Headers;
using System.Text.Json;
using TestingKwikpikAPI.Application.Interfaces;
using TestingKwikpikAPI.Domain.Entities.CreateSingleRequest;

namespace TestingKwikpikAPI.Application.Implementation
{
    public class ConfirmDispatchRequestAPI : IDispatchRequestAPI
    {
        private readonly HttpClient httpClient;

        public ConfirmDispatchRequestAPI(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<CreateSingleRequest> CreateSingleRequest(CreateSingleRequest singleRequestDTO)
        {
            try
            {
                var payLoad = new
                {
                    //data = singleRequestDTO.result.data
                    location = singleRequestDTO.result.data.location,
                    package_details = singleRequestDTO.result.data.packageDetails,
                    phone_number = singleRequestDTO.result.data.phoneNumber,
                    recipient_name = singleRequestDTO.result.data.recipientName,
                    recipient_phoneNumber = singleRequestDTO.result.data.recipientPhoneNumber,
                    sender_name = singleRequestDTO.result.data.senderName,
                    singleRequestDTO.result.data.currency,
                    selected_vehicle_type = singleRequestDTO.result.data.selectedVehicleType,
                    singleRequestDTO.result.data.destination,
                    user_type = singleRequestDTO.result.data.userType,
                };

                var baseUri = new Uri("https://dev-gateway.kwikpik.io/api/");
                var uri = new Uri(baseUri, "broker/init_request_ride/business");

                httpClient.BaseAddress = baseUri;
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc");

                var result = await httpClient.PostAsJsonAsync(uri, payLoad);
                var response = await result.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<CreateSingleRequest>(response);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
