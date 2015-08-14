using SkyLo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;

namespace SkyLo.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles = "SuperAdmin, Admin")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AddStock()
        {
            StockModel model = new StockModel();

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "SuperAdmin, Admin")]
        public ViewResult AddRole()
        {
            var model = new RoleViewModel();
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "SuperAdmin, Admin")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddRole(RoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var roleManager = HttpContext.GetOwinContext().Get<ApplicationRoleManager>();

                var newRole = new ApplicationRole(model.RoleName);
                newRole.Description = model.RoleDescription;

                var roleResult = await roleManager.CreateAsync(newRole);

                if (!roleResult.Succeeded)
                {
                    ModelState.AddModelError("", roleResult.Errors.First());
                    return View();
                }

                return RedirectToAction("AddRole");
            }


            return View();
        }

        [HttpGet]
        [Authorize(Roles="SuperAdmin, Admin")]
        public ViewResult AddUserToRole()
        {
            var model = new UserRoleViewModel();

            PopulateAddNewRoleDropdown();

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "SuperAdmin, Admin")]
        [ValidateAntiForgeryToken]
        public async Task<ViewResult> AddUserToRole(UserRoleViewModel model)
        {
            PopulateAddNewRoleDropdown();

            if (ModelState.IsValid)
            {
                var userManger = HttpContext.GetOwinContext().Get<ApplicationUserManager>();
                var result = await userManger.AddToRoleAsync(model.SelectUser, model.SelectRole);
                if (result.Succeeded)
                {
                    
                }
            }
            
            return View(model);
        }

        private void PopulateAddNewRoleDropdown()
        {
            var userManger = HttpContext.GetOwinContext().Get<ApplicationUserManager>();
            ViewBag.UserList = userManger.Users.ToList().Where(m => m.Roles.Count() == 0); // 1 role per user

            var roleManager = HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            ViewBag.RoleList = roleManager.Roles.ToList();
        }
    }
}