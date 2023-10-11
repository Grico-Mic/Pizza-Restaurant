using Pizza_Restaurant.Models;
using Pizza_Restaurant.Repositories.Interfaces;

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
    }
}
