using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.Data_Access.ConfirmSingleRequestRepo;

namespace TestingKwikpikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmSingleRequestController : ControllerBase
    {
        private readonly IConfirmSingleRequestAPI confirmSingleRequestAPI;

        public ConfirmSingleRequestController(IConfirmSingleRequestAPI confirmSingleRequestAPI)
        {
            this.confirmSingleRequestAPI = confirmSingleRequestAPI;
        }

        [HttpPost("requestId")]
        public async Task<IActionResult> ConfirmSingleRequest(string requestId)
        {
            var response = await confirmSingleRequestAPI.ConfirmSingleRequest(requestId);
            return Ok(response);
        }
    }
}
