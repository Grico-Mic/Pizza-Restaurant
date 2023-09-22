using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_Restaurant.Mapping;
using Pizza_Restaurant.Models;
using Pizza_Restaurant.Services.Interfaces;
using Pizza_Restaurant.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Pizza_Restaurant.Pages
{
    public class MenuModel : PageModel
    {
        private readonly IMenuItemService _menuItemService;
        public MenuModel(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }
       public List<MenuItemViewModel> MenuItems { get; set; }
        public void OnGet()
        {
            List<MenuItem> menuItems = _menuItemService.GetAll();
            MenuItems = menuItems.Select(x => x.ToViewModel()).ToList();
        }
    }

   
}
