using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_Restaurant.ViewModels;

namespace Pizza_Restaurant.Pages
{
    public class ConfirmationPageModel : PageModel
    {
        public string Message { get; set; }
        public void OnGetOrderCompleted()
        {
            Message = "Thanks for ordering.Enjoy your meal.";
        }
        public void OnGetSubscriptionCompleted()
        {
            Message = "Thanks for your subscription.Stay tuned for more offers and products";
        }
    }
}
