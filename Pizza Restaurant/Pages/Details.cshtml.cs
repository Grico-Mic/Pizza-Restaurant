using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_Restaurant.Mapping;
using Pizza_Restaurant.Models;
using Pizza_Restaurant.Services.Interfaces;
using Pizza_Restaurant.ViewModels;

namespace Pizza_Restaurant.Pages
{
    public class DetailsModel : PageModel
    {
        
            private readonly IMenuItemService _menuItemService;

            public DetailsModel(IMenuItemService menuItemService)
            {
                _menuItemService = menuItemService;
            }

            public MenuItemViewModel MenuItem { get; set; }

            public string ErrorMessage { get; set; }

            public void OnGet(int id)
            {
                MenuItem menuItem = _menuItemService.GetById(id);

                if (menuItem == null)
                {
                    ErrorMessage = "The item could not be found";
                }
                else
                {
                    MenuItem = menuItem.ToViewModel();
                }
            }
        }

       
    }

