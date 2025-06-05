using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<UDbTable> Users { get; set; }
    }

    public class UDbTable
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // AES-encrypted
        public virtual ICollection<Role> Roles { get; set; }
    }
}
