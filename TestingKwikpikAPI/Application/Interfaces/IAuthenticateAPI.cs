using TestingKwikpikAPI.Domain.Entities.Authenticate;

namespace TestingKwikpikAPI.Application.Interfaces
{
    public interface IAuthenticateAPI
    {
        Task<Authenticate> GetAuthentication();
    }
}


