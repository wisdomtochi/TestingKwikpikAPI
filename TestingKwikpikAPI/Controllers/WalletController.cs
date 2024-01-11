using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.Data_Access.WalletRepo;

namespace TestingKwikpikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly WalletAPI walletAPI;

        public WalletController(WalletAPI walletAPI)
        {
            this.walletAPI = walletAPI;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await walletAPI.GetWalletDetails();
            return Ok(response);
        }
    }
}
