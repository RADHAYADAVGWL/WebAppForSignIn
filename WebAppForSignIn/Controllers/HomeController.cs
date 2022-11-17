using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppForSignIn.Models;

namespace WebAppForSignIn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            Login login=new Login();
            return View(login);
        }
           
        
        [HttpPost]
        public IActionResult Login(Login login)
        {
            if(login.Username=="user@gmail.com"&&login.Password=="12345678")
            {
              return  RedirectToAction("Dashboard", "Home", new {area="User" });  
            }
            else if(login.Username == "admin@gmail.com" && login.Password == "12345678")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            else 
            {
                return RedirectToAction("Index", "Home");
            }
            return View();

        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}