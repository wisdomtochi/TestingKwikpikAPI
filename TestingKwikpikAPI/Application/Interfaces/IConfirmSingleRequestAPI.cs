using TestingKwikpikAPI.Domain.Entities.ConfirmSingleRequest;

namespace TestingKwikpikAPI.Application.Interfaces
{
    public interface IConfirmSingleRequestAPI
    {
        Task<ConfirmSingleRequest> ConfirmSingleRequest(string requestId);
    }
}
