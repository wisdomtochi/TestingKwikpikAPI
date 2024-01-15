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

        public async Task<Enum> CreateDispatchRequest(CreateDispatchRequestDTO dispatchRequestDTO)
        {
            try
            {
                var payLoad = new { key = "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc" };

                var baseUri = new Uri("https://dev-gateway.kwikpik.io/api/");
                var uri = new Uri(baseUri, "broker/init_request_ride/business");

                httpClient.BaseAddress = baseUri;
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc");


                //var stringContent = new StringContent(payLoad, UnicodeEncoding.UTF8, "application/json");
                var result = await httpClient.PostAsJsonAsync(uri, (object)payLoad);
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
