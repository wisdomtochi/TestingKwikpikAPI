using TestingKwikpikAPI.Domain.Entities.Authenticate;

namespace TestingKwikpikAPI.Application.AuthenticateRepo
{
    public interface IAuthenticateAPI
    {
        Task<Authenticate> GetAuthentication();
    }
}


