using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Pizza_Restaurant.Models
{
    public class AplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
