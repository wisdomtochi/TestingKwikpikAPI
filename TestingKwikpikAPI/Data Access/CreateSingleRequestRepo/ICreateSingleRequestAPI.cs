using TestingKwikpikAPI.DTO.CreateSingleRequest;

namespace TestingKwikpikAPI.Data_Access.CreateSingleRequestRepo
{
    public interface ICreateSingleRequestAPI
    {
        Task<string> CreateSingleRequest(CreateSingleRequestDTO CreateSingleRequestDTO);
    }
}
