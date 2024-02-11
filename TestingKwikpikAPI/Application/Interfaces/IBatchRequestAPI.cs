using TestingKwikpikAPI.Domain.Entities.BatchRequest;

namespace TestingKwikpikAPI.Application.Interfaces
{
    public interface IBatchRequestAPI
    {
        Task<BatchRequest> CreateBatchRequest(BatchRequest batchRequestDTO);
    }
}
