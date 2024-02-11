using System.Net.Http.Headers;
using System.Text.Json;
using TestingKwikpikAPI.Domain.Entities.BatchRequestConfirmation;

namespace TestingKwikpikAPI.Application.BatchRequestConfirmationRepo
{
    public class BatchRequestConfirmationAPI : IBatchRequestConfirmationAPI
    {
        private readonly HttpClient httpClient;

        public BatchRequestConfirmationAPI(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<BatchRequestConfirmation> ConfirmBatchRequest(BatchRequestConfirmation confirmBatchRequestDTO)
        {
            //    bool hasItems = confirmBatchRequestDTO.result.Any();
            //    if (hasItems)
            //    {
            try
            {
                var confirmBatchRequest = new
                {
                    confirmBatchRequestDTO.result
                };

                var baseUri = new Uri("https://dev-gateway.kwikpik.io/api/");
                var uri = new Uri(baseUri, "broker/confirm_multiple_ride_request/business");

                httpClient.BaseAddress = baseUri;
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc");

                var jsonContent = JsonContent.Create(confirmBatchRequest);
                var result = await httpClient.PostAsync(uri, jsonContent);
                var response = await result.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<BatchRequestConfirmation>(response);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
