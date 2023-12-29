using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.DTOs.AuthenticateDTO;
using TestingKwikpikAPI.DTOs.HomeDTO;

namespace TestingKwikpikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeAPI homeAPI;
        private readonly IAuthenticateAPI authenticateAPI;

        public HomeController(IHomeAPI homeAPI, IAuthenticateAPI authenticateAPI)
        {
            this.homeAPI = homeAPI;
            this.authenticateAPI = authenticateAPI;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var message = await homeAPI.GetMessage();
                return Ok(message);
            }
            catch (HttpRequestException ex)
            {
                return BadRequest($"{ex.Message}");
            }

        }
    }
}
