using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.Data_Access.ConfirmBatchRequestRepo;

namespace TestingKwikpikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmBatchRequestController : ControllerBase
    {
        private readonly IConfirmBatchRequestAPI confirmBatchRequestAPI;

        public ConfirmBatchRequestController(IConfirmBatchRequestAPI confirmBatchRequestAPI)
        {
            this.confirmBatchRequestAPI = confirmBatchRequestAPI;
        }

        [HttpGet]
        public IActionResult GetAction()
        {
            var word = "Hellow World";
            return Ok(word);
        }

        //[HttpPost]
        //public async Task<IActionResult> ConfirmBatch(ConfirmBatchRequestDTO confirmBatchRequest)
        //{
        //    var result = await confirmBatchRequestAPI.ConfirmBatchRequest(confirmBatchRequest);
        //    return Ok(result);
        //}
    }
}
