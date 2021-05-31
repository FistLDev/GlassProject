﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using GlassProject.models.domain_models;
using GlassProject.models.view_models;
using GlassProject.repositories.adapters;
using GlassProject.repositories.adapters.interfaces;
using GlassProject.repositories.contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GlassProject.controllers
{
    public class ProjectManagementController : Controller
    {
        public ProjectManagementController(IHttpContextAccessor httpContextAccessor, UserManager<User> userManager, ApplicationDbContext context)
        {
            UserId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            UserManager = userManager;
            OrderAdapter = new OrderAdapter(context);
        }
        
        private IOrderAdapter OrderAdapter { get; set; }
        private UserManager<User> UserManager { get; set; }
        private string UserId { get; set; }

        [Authorize]
        [Route("account")]
        public IActionResult ProjectManager()
        {
            ProjectManager model = new ProjectManager();
            model.Orders = OrderAdapter.GetOrdersByUser(UserId);
            ViewBag.CurrentPage = "my-projects";
            return View(model);
        }
        
        [Authorize]
        [HttpGet]
        [Route("create-site-project")]
        public IActionResult CreateProject()
        {
            ViewBag.CurrentPage = "create-project";
            return View();
        }

        [Authorize]
        [HttpPost]
        [Route("create-site-project")]
        public IActionResult CreateProject(CreateProject model)
        {
            ViewBag.CurrentPage = "create-project";

            if (!OrderAdapter.IsOrderNameUniq(model.Name, UserId))
            {
                ModelState.AddModelError("Name", "A project with this name already exists");
            }
            
            if (ModelState.IsValid)
            {
                OrderAdapter.CreateOrder(model.Name, UserId, "site", model.Structure, model.Purpose, model.Requirements, model.Description);
                return RedirectToAction("ProjectManager", "ProjectManagement");
            }
            return View();
        }

        //TODO Удалить, если не понадобится
        /*private async Task<User> GetUserAsync(string id)
        {
            return await UserManager.FindByIdAsync(id);
        }*/
    }
}