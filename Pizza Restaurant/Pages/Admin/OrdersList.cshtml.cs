using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_Restaurant.Mapping;
using Pizza_Restaurant.Models;
using Pizza_Restaurant.Services.Interfaces;
using Pizza_Restaurant.ViewModels;

namespace Pizza_Restaurant.Pages.Admin
{
    public class OrdersListModel : PageModel
    {
        private readonly IOrderService _orderService;

        public OrdersListModel(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public List<OrdersListViewModel> OrdersList { get; set; }
        public void OnGet()
        {
           var orders = _orderService.GetAll();
            OrdersList = orders.Select(x => x.ToViewModel()).ToList();


        }
        public IActionResult OnGetSetProcessed(int id)
        {
            _orderService.SetProcessed(id);
            return RedirectToPage();
        }
    }
}
