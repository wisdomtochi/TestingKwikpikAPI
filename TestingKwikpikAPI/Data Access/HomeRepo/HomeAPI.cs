using System.Net.Http.Headers;
using System.Text.Json;
using TestingKwikpikAPI.DTO.Home;

namespace TestingKwikpikAPI.Data_Access.HomeRepo
{
    public class HomeAPI : IHomeAPI
    {
        private readonly HttpClient httpClient;

        public HomeAPI(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory.CreateClient();
        }

        public async Task<HomeDTO> GetMessage()
        {
            httpClient.BaseAddress = new Uri("https://gateway.kwikpik.io");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.GetAsync("/api");
            //response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<HomeDTO>(result);
        }
    }
}
