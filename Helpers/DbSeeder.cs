using System.Linq;
using Domain.DbContext;

using Helpers.RoleSeeds;

namespace Helpers
{
    public static class DbSeeder
    {
        public static void EnsureRolesExist()
        {
            using (var db = new UserContext())
            {
                UserSeeder.Seed(db);
                ModeratorSeeder.Seed(db);
                AdminSeeder.Seed(db);
                AdminSeeder.EnsureAdminUser(db);
            }
        }
    }
}
