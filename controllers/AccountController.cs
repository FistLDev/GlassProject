using System.Threading.Tasks;
using GlassProject.models.domain_models;
using GlassProject.models.view_models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GlassProject.controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<UserDomainModel> _userManager;
        private readonly SignInManager<UserDomainModel> _signInManager;

        public AccountController(UserManager<UserDomainModel> userManager, SignInManager<UserDomainModel> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserDomainModel user = new UserDomainModel() {Email = model.Email, UserName = model.Name};
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("HomePage", "Home");
                }

                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(SignInViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Name, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("HomePage", "Home");
                }

                else
                {
                    ModelState.AddModelError("","Wrong Name or Password");
                }
            }

            return View(model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("HomePage", "Home");
        }
    }
}