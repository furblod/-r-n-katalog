using Abc.MvvWebUI.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvvWebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            if (!context.Roles.Any(i=>i.Name=="admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() {Name="admin" ,Description="admin rolü"};
                manager.Create(role);
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user rolü" };
                manager.Create(role);
            }
            if (!context.Users.Any(i => i.UserName == "furkan"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "furkan", Surname = "vatan", UserName = "furkan", Email = "furkan@gmail.com" };

                var result = manager.Create(user, "Password123!");

                if (!result.Succeeded)
                {
                    // Hataları burada yazdırıyoruz
                    var errors = string.Join(", ", result.Errors);
                    throw new Exception($"Kullanıcı oluşturulamadı: {errors}");
                }

                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }


            if (!context.Users.Any(i => i.UserName == "emir"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "emir", Surname = "vatan", UserName = "emir", Email = "emir@gmail.com" };

                manager.Create(user, "Password123!");
                manager.AddToRole(user.Id, "user");         
            }
            base.Seed(context);
        }
    }
}