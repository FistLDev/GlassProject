using Microsoft.AspNetCore.Mvc;

namespace GlassProject.controllers
{
    public class PersonalAccountController : Controller
    {
        public IActionResult PersonalAccount()
        {
            return View();
        }
    }
}