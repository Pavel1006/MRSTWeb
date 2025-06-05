using System.Linq;
using Domain.DbContext;
using Domain.Entities;

namespace Helpers.RoleSeeds
{
    public static class ModeratorSeeder
    {
        public static void Seed(UserContext db)
        {
            if (!db.Roles.Any(r => r.Name == "Moderator"))
            {
                db.Roles.Add(new Role { Name = "Moderator" });
                db.SaveChanges();
            }
        }
    }
}
