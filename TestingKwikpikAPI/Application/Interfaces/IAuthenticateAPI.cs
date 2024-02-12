using TestingKwikpikAPI.Application.Implementation;

namespace TestingKwikpikAPI.Application.Interfaces
{
    public interface IAuthenticateAPI
    {
        Task<AuthenticateAPI> GetAuthentication();
    }
}


