using TestingKwikpikAPI.Domain.Entities.ConfirmSingleRequest;

namespace TestingKwikpikAPI.Application.Interfaces
{
    public interface IRequestConfirmationAPI
    {
        Task<ConfirmSingleRequest> ConfirmSingleRequest(string requestId);
    }
}
