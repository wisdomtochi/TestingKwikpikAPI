using TestingKwikpikAPI.DTO.GetDispatchRequest;

namespace TestingKwikpikAPI.Data_Access.GetDispatchRequestRepo
{
    public interface IGetDispatchRequestAPI
    {
        Task<GetDispatchRequestDTO> GetDispatchRequest(string id);
    }
}
