using Microsoft.AspNetCore.Mvc;

namespace WebAppForSignIn.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        
       
        public IActionResult Dashboard()
        {

            return View();
        }
        public IActionResult Userprofile()
        {

            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }


        //public IActionResult Index(UserLoginModel model)
        //{
        //    if(model.Username=="user@gmail.com"&& model.Password=="12345678")
        //    {
        //        return RedirectToAction("Index", "Home", new {area="User" });
        //    }
        //    else

        //    return View("~/User/Views/Home/Index.cshtml",model);
        //}
    }
}
