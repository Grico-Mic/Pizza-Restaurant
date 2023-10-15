using Pizza_Restaurant.Models;
using System.ComponentModel.DataAnnotations;

namespace Pizza_Restaurant.ViewModels
{
    public class OrdersListViewModel
    {
        public int Id { get; set; }
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
        public OrderStatus Status { get; set; }
    }
}
