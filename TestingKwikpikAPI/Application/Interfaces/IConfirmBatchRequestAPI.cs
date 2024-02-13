using TestingKwikpikAPI.Domain.Entities.BatchRequestConfirmation;

namespace TestingKwikpikAPI.Application.Interfaces
{
    public interface IConfirmBatchRequestAPI
    {
        Task<ConfirmBatchRequest> ConfirmBatchRequest(ConfirmBatchRequest confirmBatchRequestDTO);
    }
}
