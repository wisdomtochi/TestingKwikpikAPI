using System.Net.Http.Headers;
using System.Text.Json;
using TestingKwikpikAPI.DTO.ConfirmBatchRequest;

namespace TestingKwikpikAPI.Data_Access.ConfirmBatchRequestRepo
{
    public class ConfirmBatchRequestAPI : IConfirmBatchRequestAPI
    {
        private readonly HttpClient httpClient;

        public ConfirmBatchRequestAPI(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<ConfirmBatchRequestDTO> ConfirmBatchRequest(ConfirmBatchRequestDTO confirmBatchRequestDTO)
        {
            //    bool hasItems = confirmBatchRequestDTO.result.Any();
            //    if (hasItems)
            //    {
            try
            {
                var confirmBatchRequest = new
                {
                    result = confirmBatchRequestDTO.result
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
                return JsonSerializer.Deserialize<ConfirmBatchRequestDTO>(response);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
