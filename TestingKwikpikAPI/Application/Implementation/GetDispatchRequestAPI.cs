using System.Net.Http.Headers;
using System.Text.Json;
using TestingKwikpikAPI.Application.Interfaces;
using TestingKwikpikAPI.Domain.Entities.GetDispatchRequest;

namespace TestingKwikpikAPI.Application.Implementation
{
    public class GetDispatchRequestAPI : IGetDispatchRequestAPI
    {
        private readonly HttpClient httpClient;

        public GetDispatchRequestAPI(HttpClient httpCLient)
        {
            httpClient = httpCLient;
        }
        public async Task<GetDispatchRequest> GetDispatchRequest(string id)
        {
            try
            {
                httpClient.BaseAddress = new Uri("https://dev-gateway.kwikpik.io/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc");

                var result = await httpClient.GetAsync("ride_request/" + id);
                var response = await result.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<GetDispatchRequest>(response);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
