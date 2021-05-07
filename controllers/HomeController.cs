using Microsoft.AspNetCore.Mvc;

namespace GlassProject.controllers
{
    public class HomeController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
    }
}