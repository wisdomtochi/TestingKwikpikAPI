using TestingKwikpikAPI.Domains;

namespace TestingKwikpikAPI.DTOs.AuthenticateDTO
{
    public interface IAuthenticateAPI
    {
        Task<Authenticate> GetAuthentication();
    }
}
