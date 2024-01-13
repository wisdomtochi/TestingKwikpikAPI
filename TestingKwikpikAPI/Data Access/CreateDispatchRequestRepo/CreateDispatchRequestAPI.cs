using System.Net.Http.Headers;
using TestingKwikpikAPI.DTO.CreateDispatchRequest;
using TestingKwikpikAPI.Utility.Enums;

namespace TestingKwikpikAPI.Data_Access.CreateDispatchRequestRepo
{
    public class CreateDispatchRequestAPI : ICreateDispatchRequestAPI
    {
        private readonly HttpClient httpClient;

        public CreateDispatchRequestAPI(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Enum> CreateDispatchRequest(CreateDispatchRequestDTO createDispatchRequestDTO)
        {
            try
            {
                httpClient.BaseAddress = new Uri("https://dev-gateway.kwikpik.io/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc");

                var result = await httpClient.GetAsync("broker/init_request_ride/business");
                var response = await result.Content.ReadAsStringAsync();
                return Enums.DispatchRequestCreated;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
