using System.Linq;
using Domain.DbContext;
using Domain.Entities;
using Helpers;

namespace Helpers.RoleSeeds
{
    public static class AdminSeeder
    {
        public static void Seed(UserContext db)
        {
            if (!db.Roles.Any(r => r.Name == "Admin"))
            {
                db.Roles.Add(new Role { Name = "Admin" });
                db.SaveChanges();
            }
        }

        public static void EnsureAdminUser(UserContext db)
        {
            var adminRole = db.Roles.First(r => r.Name == "Admin");

            if (!db.Users.Any(u => u.Username == "admin"))
            {
                var adminUser = new UDbTable
                {
                    Username = "admin",
                    Email = "admin@example.com",
                    Password = AES.Encrypt("AdminPassword123"),
                    Roles = new System.Collections.Generic.List<Role> { adminRole }
                };
                db.Users.Add(adminUser);
                db.SaveChanges();
            }
        }
    }
}
