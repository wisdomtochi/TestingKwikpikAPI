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

            //throw new NotImplementedException();
            try
            {
                dynamic payLoad = new System.Dynamic.ExpandoObject();
                payLoad.location = singleRequestDTO.result.data.location;
                payLoad.package_details = singleRequestDTO.result.data.packageDetails;
                payLoad.phone_number = singleRequestDTO.result.data.phoneNumber;
                payLoad.recipient_name = singleRequestDTO.result.data.recipientName;
                payLoad.recipient_phoneNumber = singleRequestDTO.result.data.recipientPhoneNumber;
                payLoad.sender_name = singleRequestDTO.result.data.senderName;
                payLoad.currency = singleRequestDTO.result.data.currency;
                payLoad.selected_vehicle_type = singleRequestDTO.result.data.selectedVehicleType;
                payLoad.destination = singleRequestDTO.result.data.destination;
                payLoad.user_type = singleRequestDTO.result.data.userType;

                var baseUri = new Uri("https://dev-gateway.kwikpik.io/api/");
                var uri = new Uri(baseUri, "broker/init_request_ride/business");

                httpClient.BaseAddress = baseUri;
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc");

                var jsonContent = JsonContent.Create(payLoad);
                var result = await httpClient.PostAsync(uri, jsonContent);
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
