namespace SkyLo.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using SkyLo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web;

    internal sealed class Configuration : DbMigrationsConfiguration<SkyLo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SkyLo.Models.ApplicationDbContext";
        }

        protected override void Seed(SkyLo.Models.ApplicationDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var roleManger = new RoleManager<ApplicationRole>(new RoleStore<ApplicationRole>(new ApplicationDbContext()));

            manager.Create(new ApplicationUser() { UserName = "ngnh_mtam@yahoo.com", Email = "ngnh_mtam@yahoo.com" }, "T@m030192");
            manager.Create(new ApplicationUser() { UserName = "ngnh_mtam@gmail.com", Email = "ngnh_mtam@gmail.com" }, "T@m030192");
            manager.Create(new ApplicationUser() { UserName = "ngnh_mtam@bing.com", Email = "ngnh_mtam@bing.com" }, "T@m030192");
            manager.Create(new ApplicationUser() { UserName = "ngnh_mtam@mail.com", Email = "ngnh_mtam@mail.com" }, "T@m030192");
            manager.Create(new ApplicationUser() { UserName = "ngnh_mtam@yola.com", Email = "ngnh_mtam@yola.com" }, "T@m030192");

            roleManger.Create(new ApplicationRole() { Name = "Staff", Description = "Bar staff" });
            roleManger.Create(new ApplicationRole() { Name = "SuperAdmin", Description = "Application creator" });
            roleManger.Create(new ApplicationRole() { Name = "Admin", Description = "System admin" });

            manager.AddToRole(manager.FindByEmail("ngnh_mtam@yahoo.com").Id, "SuperAdmin");

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
