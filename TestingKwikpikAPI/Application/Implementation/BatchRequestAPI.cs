using System.Net.Http.Headers;
using System.Text.Json;
using TestingKwikpikAPI.Application.Interfaces;
using TestingKwikpikAPI.Domain.Entities.BatchRequest;

namespace TestingKwikpikAPI.Application.Implementation
{
    public class BatchRequestAPI : IBatchRequestAPI
    {
        private readonly HttpClient httpClient;

        public BatchRequestAPI(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<BatchRequest> CreateBatchRequest(BatchRequest batchRequestDTO)
        {
            try
            {
                //bool hasItems = batchRequestDTO.result.data.Any();
                var batchRequest = new
                {
                    batchRequestDTO.result.data
                };

                var baseUri = new Uri("https://dev-gateway.kwikpik.io/api/");
                var uri = new Uri(baseUri, "broker/init_multiple_ride_request/business");

                httpClient.BaseAddress = baseUri;
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc");

                //var jsonContent = JsonContent.Create(batchRequest);
                var result = await httpClient.PostAsJsonAsync(uri, batchRequest);
                var response = await result.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<BatchRequest>(response);
                //return EnumsImplementation.ConfirmationMessage(Enums.BatchRequestCreated);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
