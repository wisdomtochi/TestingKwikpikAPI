using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.Data_Access.CreateBatchRequestRepo;
using TestingKwikpikAPI.DTO.CreateBatchRequest;

namespace TestingKwikpikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateBatchRequestController : ControllerBase
    {
        private readonly CreateBatchRequestAPI createBatchRequest;

        public CreateBatchRequestController(CreateBatchRequestAPI createBatchRequest)
        {
            this.createBatchRequest = createBatchRequest;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBatchRequest([FromBody] CreateBatchRequestDTO createBatchRequestDTO)
        {
            var response = await createBatchRequest.CreateBatchRequest(createBatchRequestDTO);
            return Ok(response);
        }
    }
}
