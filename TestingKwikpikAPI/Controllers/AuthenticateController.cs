using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.Data_Access.AuthenticateRepo;

namespace TestingKwikpikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IAuthenticateAPI authenticateAPI;

        public AuthenticateController(IAuthenticateAPI authenticateAPI)
        {
            this.authenticateAPI = authenticateAPI;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await authenticateAPI.GetAuthentication();
            return Ok(response);
        }
    }
}
