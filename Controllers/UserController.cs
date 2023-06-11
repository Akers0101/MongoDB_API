using Microsoft.AspNetCore.Mvc;

namespace MongoDB_API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
