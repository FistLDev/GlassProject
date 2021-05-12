using System;
using GlassProject.models.domain_models;
using GlassProject.models.domain_models.Enums;
using GlassProject.repositories.contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GlassProject.controllers
{
    public class PersonalAccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonalAccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        [Route("account")]
        public IActionResult PersonalAccount()
        {
            ViewBag.CurrentPage = "my-projects";

            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            _context.Technologies.Add(new Technology()
            {
                TechnologyName = "sadf"
            });
            _context.SaveChanges();

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