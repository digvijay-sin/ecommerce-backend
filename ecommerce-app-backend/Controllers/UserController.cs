 using Microsoft.AspNetCore.Mvc;

namespace ecommerce_app_backend.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
