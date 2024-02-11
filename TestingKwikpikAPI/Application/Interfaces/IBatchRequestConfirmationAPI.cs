using TestingKwikpikAPI.Domain.Entities.BatchRequestConfirmation;

namespace TestingKwikpikAPI.Application.Interfaces
{
    public interface IBatchRequestConfirmationAPI
    {
        Task<BatchRequestConfirmation> ConfirmBatchRequest(BatchRequestConfirmation confirmBatchRequestDTO);
    }
}
