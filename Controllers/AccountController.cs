using Microsoft.AspNetCore.Mvc;
using ValidationApp.ViewModels;

namespace ValidationApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Мұнда деректерді сақтау логикасы болады
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}