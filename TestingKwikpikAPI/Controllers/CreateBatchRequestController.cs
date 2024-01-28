using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.Data_Access.CreateBatchRequestRepo;
using TestingKwikpikAPI.DTO.CreateBatchRequest;

namespace TestingKwikpikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateBatchRequestController : ControllerBase
    {
        private readonly ICreateBatchRequestAPI createBatchRequestAPI;

        public CreateBatchRequestController(ICreateBatchRequestAPI createBatchRequest)
        {
            this.createBatchRequestAPI = createBatchRequest;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBatchRequest(CreateBatchRequestDTO createBatch)
        {
            var response = await createBatchRequestAPI.CreateBatchRequest(createBatch);
            return Ok(response);
        }
    }
}
