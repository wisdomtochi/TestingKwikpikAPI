﻿using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.DTOs.AuthenticateDTO;

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

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            try
            {
                var response = await authenticateAPI.GetAuthentication();
                return Ok(response);
            }
            catch (HttpRequestException ex)
            {
                return BadRequest($"{ex.Message}");
            }
        }
    }
}
