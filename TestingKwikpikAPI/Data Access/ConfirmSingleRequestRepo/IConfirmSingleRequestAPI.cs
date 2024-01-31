using TestingKwikpikAPI.DTO.ConfirmSingleRequest;

namespace TestingKwikpikAPI.Data_Access.ConfirmSingleRequestRepo
{
    public interface IConfirmSingleRequestAPI
    {
        Task<ConfirmSingleRequestDTO> ConfirmSingleRequest(string requestId);
    }
}
