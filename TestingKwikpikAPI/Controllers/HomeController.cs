using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.Data_Access.HomeRepo;

namespace TestingKwikpikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeAPI homeAPI;

        public HomeController(IHomeAPI homeAPI)
        {
            this.homeAPI = homeAPI;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var message = await homeAPI.GetMessage();
            return Ok(message);
        }
    }
}
