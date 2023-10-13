using System;
using System.ComponentModel.DataAnnotations;

namespace Pizza_Restaurant.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
}
