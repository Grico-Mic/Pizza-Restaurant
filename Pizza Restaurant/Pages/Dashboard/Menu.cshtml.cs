using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pizza_Restaurant.Pages.Dashboard
{
    public class MenuModel : PageModel
    {
        [Authorize]
        public void OnGet()
        {
        }
    }
}
