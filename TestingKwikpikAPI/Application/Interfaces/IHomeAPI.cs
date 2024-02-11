using TestingKwikpikAPI.Domain.Entities.Home;

namespace TestingKwikpikAPI.Application.Interfaces
{
    public interface IHomeAPI
    {
        Task<Home> GetMessage();
    }
}
