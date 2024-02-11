using TestingKwikpikAPI.Domain.Entities.GetDispatchRequest;

namespace TestingKwikpikAPI.Application.Interfaces
{
    public interface IGetDispatchRequestAPI
    {
        Task<GetDispatchRequest> GetDispatchRequest(string id);
    }
}
