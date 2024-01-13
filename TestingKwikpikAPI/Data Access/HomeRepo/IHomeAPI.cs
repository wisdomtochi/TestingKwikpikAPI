using TestingKwikpikAPI.DTO.Home;

namespace TestingKwikpikAPI.Data_Access.HomeRepo
{
    public interface IHomeAPI
    {
        Task<HomeDTO> GetMessage();
    }
}
