using Pizza_Restaurant.Models;
using Pizza_Restaurant.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Pizza_Restaurant.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly PizzaRestaurantDbContex _dbContext;

        public OrderRepository(PizzaRestaurantDbContex dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(Order newOrder)
        {
            _dbContext.Orders.Add(newOrder);
            _dbContext.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return _dbContext.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _dbContext.Orders.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Order order)
        {
            _dbContext.Orders.Update(order);
            _dbContext.SaveChanges();
        }
    }
}
