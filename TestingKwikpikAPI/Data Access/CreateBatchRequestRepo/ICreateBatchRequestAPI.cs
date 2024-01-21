using TestingKwikpikAPI.DTO.CreateBatchRequest;

namespace TestingKwikpikAPI.Data_Access.CreateBatchRequestRepo
{
    public interface ICreateBatchRequestAPI
    {
        Task<string> CreateBatchRequest(CreateBatchRequestDTO batchRequestDTO);
    }
}
