using TestingKwikpikAPI.Domains;

namespace TestingKwikpikAPI.DTOs.HomeDTO
{
    public interface IHomeAPI
    {
        Task<Message> GetMessage();
    }
}
