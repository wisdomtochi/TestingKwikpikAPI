using System.Net.Http.Headers;
using TestingKwikpikAPI.DTO.CreateBatchRequest;
using TestingKwikpikAPI.Utility.Enums;

namespace TestingKwikpikAPI.Data_Access.CreateBatchRequestRepo
{
    public class CreateBatchRequestAPI : ICreateBatchRequestAPI
    {
        private readonly HttpClient httpClient;

        public CreateBatchRequestAPI(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<string> CreateBatchRequest(CreateBatchRequestDTO batchRequestDTO)
        {
            //throw new NotImplementedException();
            try
            {
                dynamic payLoad = new System.Dynamic.ExpandoObject();

                Datum firstDatum = batchRequestDTO.result.datum.FirstOrDefault();

                if (firstDatum == null)
                {
                    payLoad.location = firstDatum.data.location;
                    payLoad.packageDetails = firstDatum.data.packageDetails;
                    payLoad.phone_number = firstDatum.data.phoneNumber;
                    payLoad.recipient_name = firstDatum.data.recipientName;
                    payLoad.recipient_phoneNumber = firstDatum.data.recipientPhoneNumber;
                    payLoad.sender_name = firstDatum.data.senderName;
                    payLoad.currency = firstDatum.data.currency;
                    payLoad.selected_vehicle_type = firstDatum.data.selectedVehicleType;
                    payLoad.destination = firstDatum.data.destination;
                    payLoad.user_type = firstDatum.data.userType;
                }
                else
                {
                    payLoad.location = firstDatum.data.location;
                    payLoad.packageDetails = firstDatum.data.packageDetails;
                    payLoad.phone_number = firstDatum.data.phoneNumber;
                    payLoad.recipient_name = firstDatum.data.recipientName;
                    payLoad.recipient_phoneNumber = firstDatum.data.recipientPhoneNumber;
                    payLoad.sender_name = firstDatum.data.senderName;
                    payLoad.currency = firstDatum.data.currency;
                    payLoad.selected_vehicle_type = firstDatum.data.selectedVehicleType;
                    payLoad.destination = firstDatum.data.destination;
                    payLoad.user_type = firstDatum.data.userType;
                }

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
