using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.Data_Access.CreateBatchRequestRepo;

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

        [HttpGet]
        public async Task<IActionResult> GetWord()
        {
            var word = "Hello World";
            return Ok(word);
        }

        //[HttpPost]
        //public async Task<IActionResult> CreateBatchRequest(CreateBatchRequestDTO createBatch)
        //{
        //    var response = await createBatchRequestAPI.CreateBatchRequest(createBatch);
        //    return Ok(response);
        //}
    }
}
