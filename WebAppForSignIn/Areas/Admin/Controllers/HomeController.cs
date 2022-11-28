using Microsoft.AspNetCore.Mvc;
using WebAppForSignIn.Areas.User.Models;

namespace WebAppForSignIn.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Dashboard()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Dashboard(Registration registration)
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();

        }
    }
}
