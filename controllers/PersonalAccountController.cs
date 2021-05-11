using Microsoft.AspNetCore.Mvc;

namespace GlassProject.controllers
{
    public class PersonalAccountController : Controller
    {
        [Route("PersonalAccount")]
        public IActionResult PersonalAccount()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.CurrentPage = "my-projects";
                return View();
            }
            
            return RedirectToAction("SignIn", "Account", new {returnUrl = this.Url.Action("PersonalAccount", "PersonalAccount")});
        }
    }
}