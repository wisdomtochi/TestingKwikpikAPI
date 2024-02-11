using System.Net.Http.Headers;
using System.Text.Json;
using TestingKwikpikAPI.Domain.Entities.Wallet;

namespace TestingKwikpikAPI.Application.WalletRepo
{
    public class WalletAPI : IWalletAPI
    {
        private readonly HttpClient httpClient;

        public WalletAPI(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Wallet> GetWalletDetails()
        {
            try
            {
                httpClient.BaseAddress = new Uri("https://dev-gateway.kwikpik.io/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc");

                var result = await httpClient.GetAsync("wallet/business");
                var response = await result.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<Wallet>(response);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
