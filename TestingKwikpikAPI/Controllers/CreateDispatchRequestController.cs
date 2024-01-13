using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.Data_Access.CreateDispatchRequestRepo;
using TestingKwikpikAPI.DTO.CreateDispatchRequest;

namespace TestingKwikpikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateDispatchRequestController : ControllerBase
    {
        private readonly ICreateDispatchRequestAPI createDispatchRequestAPI;

        public CreateDispatchRequestController(ICreateDispatchRequestAPI createDispatchRequestAPI)
        {
            this.createDispatchRequestAPI = createDispatchRequestAPI;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDispatchRequest(CreateDispatchRequestDTO createDispatchRequestDTO)
        {
            var response = await createDispatchRequestAPI.CreateDispatchRequest(createDispatchRequestDTO);
            return Ok(response);
        }
    }
}
