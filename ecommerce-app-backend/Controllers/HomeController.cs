using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_app_backend.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("[action]")] 
        public async Task<IActionResult> Index() {
            return Ok();
        }
    }
}
 