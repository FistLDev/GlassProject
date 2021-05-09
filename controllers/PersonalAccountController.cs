using Microsoft.AspNetCore.Mvc;

namespace GlassProject.controllers
{
    public class PersonalAccountController : Controller
    {
        public IActionResult PersonalAccount()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }

            else
            {
                return RedirectToAction("SignIn", "Account");
            }
        }
    }
}