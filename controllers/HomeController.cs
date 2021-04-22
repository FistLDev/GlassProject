using Microsoft.AspNetCore.Mvc;

namespace GlassProject.controllers
{
    public class HomeController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        
        public IActionResult SignIn()
        {
            return View();
        }
    }
}