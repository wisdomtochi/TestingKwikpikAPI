using TestingKwikpikAPI.DTO.CreateDispatchRequest;

namespace TestingKwikpikAPI.Data_Access.CreateDispatchRequestRepo
{
    public interface ICreateDispatchRequestAPI
    {
        Task<Enum> CreateDispatchRequest(CreateDispatchRequestDTO createDispatchRequestDTO);
    }
}
