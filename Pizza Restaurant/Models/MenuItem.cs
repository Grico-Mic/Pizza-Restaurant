using System;
using System.ComponentModel.DataAnnotations;

namespace Pizza_Restaurant.Models
{
    public class MenuItem
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImageURL { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Currency { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
}
