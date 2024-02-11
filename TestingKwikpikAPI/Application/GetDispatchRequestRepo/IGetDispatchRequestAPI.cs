using TestingKwikpikAPI.Domain.Entities.GetDispatchRequest;

namespace TestingKwikpikAPI.Application.GetDispatchRequestRepo
{
    public interface IGetDispatchRequestAPI
    {
        Task<GetDispatchRequest> GetDispatchRequest(string id);
    }
}
