using TestingKwikpikAPI.Domain.Entities.BatchRequestConfirmation;

namespace TestingKwikpikAPI.Application.BatchRequestConfirmationRepo
{
    public interface IBatchRequestConfirmationAPI
    {
        Task<BatchRequestConfirmation> ConfirmBatchRequest(BatchRequestConfirmation confirmBatchRequestDTO);
    }
}
