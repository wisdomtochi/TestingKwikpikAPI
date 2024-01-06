using System.Net.Http.Headers;
using System.Text.Json;
using TestingKwikpikAPI.Domains;

namespace TestingKwikpikAPI.DTOs.AuthenticateDTO
{
    public class AuthenticateAPI : IAuthenticateAPI
    {
        private readonly HttpClient httpClient;

        public AuthenticateAPI(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory.CreateClient();
        }
        public async Task<Authenticate> GetAuthentication()
        {
            try
            {
                var baseUrl = "https://dev-gateway.kwikpik.io/api";
                var apiKey = "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc";


                httpClient.BaseAddress = new Uri(baseUrl);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", apiKey);

                var result = await httpClient.GetAsync("/business/authenticate");
                var response = await result.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<Authenticate>(response);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
