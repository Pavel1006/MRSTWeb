using System.Data.Entity;
using RentalCAR.Domain.Entities;

namespace RentalCAR.Domain.DbContext
{
    public class UserContext : System.Data.Entity.DbContext
    {
        public UserContext() : base("name=DefaultConnection") { }

        public DbSet<UDbTable> Users { get; set; }
    }
}

