using System.ComponentModel.DataAnnotations;

namespace RentalCAR.Domain.Entities
{
    public class UDbTable
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // AES-encrypted password
    }
}
