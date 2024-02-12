using System.Net.Http.Headers;
using System.Text.Json;
using TestingKwikpikAPI.Application.Interfaces;
using TestingKwikpikAPI.Domain.Entities.ConfirmSingleRequest;

namespace TestingKwikpikAPI.Application.Implementation
{
    public class CreateDispatchRequestAPI : IRequestConfirmationAPI
    {
        private readonly HttpClient httpClient;

        public CreateDispatchRequestAPI(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<ConfirmSingleRequest> ConfirmSingleRequest(string requestId)
        {
            try
            {
                var confirmSingleRequest = new
                {
                    data = requestId
                };

                var baseUri = new Uri("https://dev-gateway.io/api/");
                var uri = new Uri(baseUri + "broker/confirm_ride_request/business");

                httpClient.BaseAddress = baseUri;
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc");

                var result = await httpClient.PostAsJsonAsync(uri, confirmSingleRequest);
                var response = await result.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<ConfirmSingleRequest>(response);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
