using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_Restaurant.Mapping;
using Pizza_Restaurant.Services.Interfaces;
using Pizza_Restaurant.ViewModels;

namespace Pizza_Restaurant.Pages
{
    public class OrderModel : PageModel
    {
        private readonly IOrderService _orderService;
        private readonly ISubcriptionService _subcriptionService;
        public OrderModel(IOrderService orderService , ISubcriptionService subcriptionService)
        {
            _orderService = orderService;
            _subcriptionService = subcriptionService;
        }


        [BindProperty]
        public OrderViewModel Order { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var newOrder = Order.ToDomainModel();
                _orderService.Create(newOrder);

                return RedirectToPage("ConfirmationPage", "OrderCompleted");
            }
            return Page();
        }
        public  IActionResult OnPostSubscribe(string email)
        {
            _subcriptionService.Create(email);

            return RedirectToPage("ConfirmationPage", "SubscriptionCompleted");

        }
    }
}
