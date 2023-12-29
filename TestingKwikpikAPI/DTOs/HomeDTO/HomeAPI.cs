using System.Net.Http.Headers;
using System.Text.Json;
using TestingKwikpikAPI.Domains;

namespace TestingKwikpikAPI.DTOs.HomeDTO
{
    public class HomeAPI : IHomeAPI
    {
        private readonly HttpClient httpClient;

        public HomeAPI(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory.CreateClient();
        }

        public async Task<Message> GetMessage()
        {
            httpClient.BaseAddress = new Uri("https://gateway.kwikpik.io");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.GetAsync("/api");
            //response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Message>(result);
        }
    }
}
