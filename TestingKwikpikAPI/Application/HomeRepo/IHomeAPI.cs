using TestingKwikpikAPI.Domain.Entities.Home;

namespace TestingKwikpikAPI.Application.HomeRepo
{
    public interface IHomeAPI
    {
        Task<Home> GetMessage();
    }
}
