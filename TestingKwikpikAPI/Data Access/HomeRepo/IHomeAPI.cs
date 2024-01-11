using TestingKwikpikAPI.DTO;

namespace TestingKwikpikAPI.Data_Access.HomeRepo
{
    public interface IHomeAPI
    {
        Task<HomeDTO> GetMessage();
    }
}
