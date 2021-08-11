using ChallengeSolvex.Models;
using ChallengeSolvex.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeSolvex.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GraphController : ControllerBase
    {
        public MicrosoftGraphService service = new MicrosoftGraphService();
        [HttpGet("user")]
        public async Task<ActionResult> GetTokenAsync()
        {
            var result = await service.GetAllUsers();
            return Ok(result);
        }
    }
}
