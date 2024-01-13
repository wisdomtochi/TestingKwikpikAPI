﻿using System.Net.Http.Headers;
using System.Text.Json;
using TestingKwikpikAPI.DTO;

namespace TestingKwikpikAPI.Data_Access.AuthenticateRepo
{
    public class AuthenticateAPI : IAuthenticateAPI
    {
        private readonly HttpClient httpClient;

        public AuthenticateAPI(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<AuthenticateDTO> GetAuthentication()
        {
            try
            {
                httpClient.BaseAddress = new Uri("https://dev-gateway.kwikpik.io/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("X-API-Key", "fGKa77uvaeROvwh1MXR7X63VOtWXIomjBKQDbacI31EEafOD49Er4HXuALsc");

                var result = await httpClient.GetAsync("business/authenticate");
                var response = await result.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<AuthenticateDTO>(response);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
