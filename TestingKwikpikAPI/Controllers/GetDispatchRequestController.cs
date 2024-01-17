using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.Data_Access.GetDispatchRequestRepo;

namespace TestingKwikpikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetDispatchRequestController : ControllerBase
    {
        private readonly IGetDispatchRequestAPI getDispatchRequest;

        public GetDispatchRequestController(IGetDispatchRequestAPI getDispatchRequest)
        {
            this.getDispatchRequest = getDispatchRequest;
        }

        public async Task<IActionResult> GetDispatchRequest(string id)
        {
            var response = await getDispatchRequest.GetDispatchRequest(id);
            return Ok(response);
        }
    }
}
