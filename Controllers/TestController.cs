using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //sadece yetkili kişi erişir
        [Authorize]
        [HttpGet("test")]
        public IActionResult Get()
        {
            return Ok(new { message = "Test" });
        }
    }
}
}
