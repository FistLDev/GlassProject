﻿using System;
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
            return View();
        }

        [Authorize]
        [Route("choose-project-type")]
        public IActionResult ChooseProjectType()
        {
            ViewBag.CurrentPage = "create-project";
            return View();
        }
        
        [Authorize]
        [Route("create-site-project")]
        public IActionResult CreateSiteProject()
        {
            ViewBag.CurrentPage = "create-project";
            return View();
        }
    }
}