using TestingKwikpikAPI.DTO;

namespace TestingKwikpikAPI.Data_Access.AuthenticateRepo
{
    public interface IAuthenticateAPI
    {
        Task<AuthenticateDTO> GetAuthentication();
    }
}


