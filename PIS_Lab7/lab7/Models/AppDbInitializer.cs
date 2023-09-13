using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab7.Models
{
    public class AppDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            var roleAdmin = new IdentityRole { Name = "admin" };
            var roleEmp = new IdentityRole { Name = "employer" };
            var roleGuest = new IdentityRole { Name = "guest" };

            roleManager.Create(roleAdmin);
            roleManager.Create(roleEmp);
            roleManager.Create(roleGuest);

            var admin = new ApplicationUser { Email = "admin@belstu.by", UserName= "admin@belstu.by" };
            string password = "werwer";
            var result = userManager.Create(admin, password);

            if (result.Succeeded)
                userManager.AddToRole(admin.Id, roleAdmin.Name);

            var employer = new ApplicationUser { Email = "emp@belstu.by", UserName = "emp@belstu.by" };
            result = userManager.Create(employer, password);
            if (result.Succeeded)
                userManager.AddToRole(employer.Id, roleEmp.Name);

            var guest = new ApplicationUser { Email = "guest@belstu.by", UserName = "guest@belstu.by" };
            result= userManager.Create(guest, password);
            if (result.Succeeded)
                userManager.AddToRole(guest.Id, roleGuest.Name);

            var super = new ApplicationUser { Email = "super@belstu.by", UserName = "super@belstu.by" };
            result = userManager.Create(super, password);
            if (result.Succeeded)
            {
                userManager.AddToRole(super.Id, roleAdmin.Name);
                userManager.AddToRole(super.Id, roleEmp.Name);
                userManager.AddToRole(super.Id, roleGuest.Name);
            }

            base.Seed(context);
        }
    }
}