using Microsoft.AspNetCore.Mvc;

namespace MvcCrud.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
