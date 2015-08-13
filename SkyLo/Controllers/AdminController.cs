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
        public ViewResult AddRole()
        {
            var model = new RoleViewModel();
            return View(model);
        }

        [HttpPost]
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
        public ViewResult AddUserToRole()
        {
            return View();
        }
    }
}