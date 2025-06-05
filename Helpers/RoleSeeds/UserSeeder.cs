using System.Linq;
using Domain.DbContext;
using Domain.Entities;

namespace Helpers.RoleSeeds
{
    public static class UserSeeder
    {
        public static void Seed(UserContext db)
        {
            if (!db.Roles.Any(r => r.Name == "User"))
            {
                db.Roles.Add(new Role { Name = "User" });
                db.SaveChanges();
            }
        }
    }
}
