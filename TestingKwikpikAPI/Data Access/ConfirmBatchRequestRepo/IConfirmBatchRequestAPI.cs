using TestingKwikpikAPI.DTO.ConfirmBatchRequest;

namespace TestingKwikpikAPI.Data_Access.ConfirmBatchRequestRepo
{
    public interface IConfirmBatchRequestAPI
    {
        Task<ConfirmBatchRequestDTO> ConfirmBatchRequest(ConfirmBatchRequestDTO confirmBatchRequestDTO);
    }
}
