using TestingKwikpikAPI.Domain.Entities.BatchRequest;

namespace TestingKwikpikAPI.Application.BatchRequestRepo
{
    public interface IBatchRequestAPI
    {
        Task<BatchRequest> CreateBatchRequest(BatchRequest batchRequestDTO);
    }
}
