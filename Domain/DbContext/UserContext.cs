using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Entities;

namespace Domain.DbContext
{
    public class UserContext : System.Data.Entity.DbContext
    {
        public UserContext() : base("name=DefaultConnection") { }

        public DbSet<UDbTable> Users { get; set; }
    }
}
