using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_app_backend.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("[action]")]
        public async Task<IActionResult> AddUser() {

            return Ok();
        }
    }
}
