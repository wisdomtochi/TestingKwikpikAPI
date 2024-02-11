using TestingKwikpikAPI.Domain.Entities.ConfirmSingleRequest;

namespace TestingKwikpikAPI.Application.ConfirmSingleRequestRepo
{
    public interface IConfirmSingleRequestAPI
    {
        Task<ConfirmSingleRequest> ConfirmSingleRequest(string requestId);
    }
}
