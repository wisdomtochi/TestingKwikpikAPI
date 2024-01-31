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
                bool hasItems = batchRequestDTO.result.datum.Any();
                if (hasItems)
                {
                    CreateBatchRequestDTO batchRequest = new()
                    {
                        result = batchRequestDTO.result
                    };

                    var baseUri = new Uri("https://dev-gateway.kwikpik.io/api/");
                    var uri = new Uri(baseUri, "broker/init_multiple_ride_request/business");

                    httpClient.BaseAddress = baseUri;
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc");

                    var jsonContent = JsonContent.Create(batchRequest);
                    var result = await httpClient.PostAsync(uri, jsonContent);
                    var response = await result.Content.ReadAsStringAsync();
                    return EnumsImplementation.ConfirmationMessage(Enums.BatchRequestCreated);
                }
                else
                {
                    return EnumsImplementation.ConfirmationMessage(Enums.FillSomething);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
