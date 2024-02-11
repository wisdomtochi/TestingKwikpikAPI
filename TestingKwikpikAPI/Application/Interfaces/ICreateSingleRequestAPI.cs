using TestingKwikpikAPI.Domain.Entities.CreateSingleRequest;

namespace TestingKwikpikAPI.Application.Interfaces
{
    public interface ICreateSingleRequestAPI
    {
        Task<CreateSingleRequest> CreateSingleRequest(CreateSingleRequest CreateSingleRequestDTO);
    }
}
