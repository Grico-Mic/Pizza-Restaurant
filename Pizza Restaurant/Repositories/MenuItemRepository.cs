using Pizza_Restaurant.Models;
using Pizza_Restaurant.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_Restaurant.Repositories
{

    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly PizzaRestaurantDbContex _dbContext;
        public MenuItemRepository(PizzaRestaurantDbContex DbContex)
        {
            _dbContext = DbContex;
        }

        public List<MenuItem> GetAll()
        {
            return _dbContext.MenuItems.ToList();
        }

        public MenuItem GetById(int id)
        {
            return _dbContext.MenuItems.FirstOrDefault(x => x.Id == id);
        }
    }
}
