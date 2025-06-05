using System.Linq;
using Domain.DbContext;
using Domain.Entities;

namespace Helpers
{
    public static class DbSeeder
    {
        public static void EnsureRolesExist()
        {
            using (var db = new UserContext())
            {
                if (!db.Roles.Any())
                {
                    db.Roles.Add(new Role { Name = "User" });
                    db.Roles.Add(new Role { Name = "Admin" });
                    db.Roles.Add(new Role { Name = "Moderator" });
                    db.SaveChanges();
                }
            }
        }
    }
}
