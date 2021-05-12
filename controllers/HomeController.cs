using Microsoft.AspNetCore.Mvc;

namespace GlassProject.controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult HomePage()
        {
            return View();
        }
    }
}