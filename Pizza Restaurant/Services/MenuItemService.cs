using Pizza_Restaurant.Models;
using Pizza_Restaurant.Repositories.Interfaces;
using Pizza_Restaurant.Services.Interfaces;
using System.Collections.Generic;

namespace Pizza_Restaurant.Services
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepository _menuItemRepository;
        public MenuItemService(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }
        public List<MenuItem> GetAll()
        {
            return _menuItemRepository.GetAll();
        }

        public MenuItem GetBySlug(string slug)
        {
            return _menuItemRepository.GetBySlug(slug);
        }
    }
}
