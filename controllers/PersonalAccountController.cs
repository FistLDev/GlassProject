using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GlassProject.controllers
{
    public class PersonalAccountController : Controller
    {

        [Authorize]
        [Route("account")]
        public IActionResult PersonalAccount()
        {
            ViewBag.CurrentPage = "my-projects";
            return View();
        }

        [Authorize]
        [Route("create-project")]
        public IActionResult CreateProject()
        {
            ViewBag.CurrentPage = "create-project";
            return View();
        }
        
    }
}