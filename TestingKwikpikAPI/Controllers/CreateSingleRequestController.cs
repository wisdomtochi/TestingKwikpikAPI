using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.Data_Access.CreateSingleRequestRepo;
using TestingKwikpikAPI.DTO.CreateSingleRequest;

namespace TestingKwikpikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateSingleRequestController : ControllerBase
    {
        private readonly ICreateSingleRequestAPI CreateSingleRequestAPI;

        public CreateSingleRequestController(ICreateSingleRequestAPI CreateSingleRequestAPI)
        {
            this.CreateSingleRequestAPI = CreateSingleRequestAPI;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSingleRequest(CreateSingleRequestDTO CreateSingleRequestDTO)
        {
            var response = await CreateSingleRequestAPI.CreateSingleRequest(CreateSingleRequestDTO);
            return Ok(response);
        }
    }
}
