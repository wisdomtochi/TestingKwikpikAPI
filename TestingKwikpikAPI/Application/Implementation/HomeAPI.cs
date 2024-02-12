using System.Net.Http.Headers;
using System.Text.Json;
using TestingKwikpikAPI.Application.Interfaces;

namespace TestingKwikpikAPI.Application.Implementation
{
    public class HomeAPI : IHomeAPI
    {
        private readonly HttpClient httpClient;

        public HomeAPI(IHttpClientFactory httpClientFactory)
        {
            httpClient = httpClientFactory.CreateClient();
        }

        public async Task<Domain.Entities.Home.Home> GetMessage()
        {
            httpClient.BaseAddress = new Uri("https://gateway.kwikpik.io");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.GetAsync("/api");
            var result = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Domain.Entities.Home.Home>(result);
        }
    }
}
