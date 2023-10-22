using Pizza_Restaurant.Models;
using System.Collections.Generic;

namespace Pizza_Restaurant.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void Create(Order newOrder);
        List<Order> GetAll();
        Order GetById(int id);
        void Update(Order order);
        List<Order> GetStatus(OrderStatus orderStatus);
    }
}
