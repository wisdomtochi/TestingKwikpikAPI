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

        public async Task<string> CreateSingleRequest(CreateSingleRequestDTO dispatchRequestDTO)
        {

            //throw new NotImplementedException();
            try
            {
                dynamic payLoad = new System.Dynamic.ExpandoObject();
                payLoad.location = dispatchRequestDTO.result.data.location;
                payLoad.package_details = dispatchRequestDTO.result.data.packageDetails;
                payLoad.phone_number = dispatchRequestDTO.result.data.phoneNumber;
                payLoad.recipient_name = dispatchRequestDTO.result.data.recipientName;
                payLoad.recipient_phoneNumber = dispatchRequestDTO.result.data.recipientPhoneNumber;
                payLoad.sender_name = dispatchRequestDTO.result.data.senderName;
                payLoad.currency = dispatchRequestDTO.result.data.currency;
                payLoad.selected_vehicle_type = dispatchRequestDTO.result.data.selectedVehicleType;
                payLoad.destination = dispatchRequestDTO.result.data.destination;
                payLoad.user_type = dispatchRequestDTO.result.data.userType;


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
