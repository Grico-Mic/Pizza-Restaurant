using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_Restaurant.Mapping;
using Pizza_Restaurant.Models;
using Pizza_Restaurant.Services.Interfaces;
using Pizza_Restaurant.ViewModels;

namespace Pizza_Restaurant.Pages.Admin
{
    [Authorize(Roles ="Admin,Cook,Delivery")]
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

        public void OnGetPendingOrders()
        {
            var orders = _orderService.GetStatus(OrderStatus.Pending);
            OrdersList = orders.Select(x => x.ToViewModel()).ToList();
        }

        public void OnGetProcessed()
        {
            var orders = _orderService.GetStatus(OrderStatus.Processed);
            OrdersList = orders.Select(x => x.ToViewModel()).ToList();
        }
        public void OnGetDone()
        {
            var orders = _orderService.GetStatus(OrderStatus.Done);
            OrdersList = orders.Select(x => x.ToViewModel()).ToList();
        }


        public IActionResult OnGetSetProcessed(int id)
        {
            _orderService.SetStatus(id,OrderStatus.Processed);
            return RedirectToPage("OrdersList","PendingOrders");
        }

        public IActionResult OnGetSetDone(int id)
        {
            _orderService.SetStatus(id, OrderStatus.Done);
            return RedirectToPage("OrdersList", "Processed");
        } 
    }
}
