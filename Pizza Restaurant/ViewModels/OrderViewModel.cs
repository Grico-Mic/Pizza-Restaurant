﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Pizza_Restaurant.ViewModels
{
    public class OrderViewModel
    {
        
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Message { get; set; }

       
    }
}
