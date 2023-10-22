using Pizza_Restaurant.Models;
using System.Collections.Generic;

namespace Pizza_Restaurant.Services.Interfaces
{
    public interface IOrderService
    {
        void Create(Order newOrder);
        List<Order> GetAll();
      
        List<Order> GetStatus(OrderStatus orderStatus);
      
        void SetStatus(int id, OrderStatus status);
    }
}
