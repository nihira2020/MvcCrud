using Microsoft.AspNetCore.Mvc;

namespace MvcCrud.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(string code)
        {
            ViewData["editcode"] = code;
            return View();
        }
    }
}
