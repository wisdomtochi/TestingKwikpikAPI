using TestingKwikpikAPI.Domain.Entities.CreateSingleRequest;

namespace TestingKwikpikAPI.Application.Interfaces
{
    public interface IDispatchRequestAPI
    {
        Task<CreateSingleRequest> CreateSingleRequest(CreateSingleRequest CreateSingleRequestDTO);
    }
}
