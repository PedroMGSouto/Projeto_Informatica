﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Pmat_PI.Identity.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        public RoleController(RoleManager<IdentityRole> roleMgr)
        {
            roleManager = roleMgr;
        }

        public ViewResult Index() => View(roleManager.Roles);

        public ViewResult Index1() => View(roleManager.Roles);

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        public IActionResult Create() => View();

        // CREATE ROLE go to localhost(....)/Role/Create.
        [HttpPost]
        public async Task<IActionResult> Create([Required] string name)
        {
            Console.WriteLine("INSIDE CREATE ROLE!");
            if (ModelState.IsValid)
            {
                IdentityResult result = await roleManager.CreateAsync(new IdentityRole(name));
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            return View(name);
        }

        // DELETE ROLE 
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            Console.WriteLine("Inside Delete Role function!");
            IdentityRole role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                Console.WriteLine("Role Exists !");
                IdentityResult result = await roleManager.DeleteAsync(role);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            else
                ModelState.AddModelError("", "No role found");
            return View("Index", roleManager.Roles);
        }
    }
}