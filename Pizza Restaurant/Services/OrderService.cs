﻿using Pizza_Restaurant.Models;
using Pizza_Restaurant.Repositories.Interfaces;
using Pizza_Restaurant.Services.Interfaces;
using System.Collections.Generic;

namespace Pizza_Restaurant.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Create(Order newOrder)
        {
            newOrder.Status = OrderStatus.Pending;
            _orderRepository.Create(newOrder);
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public Order SetProcessed(int id)
        {
            Order order = _orderRepository.GetById(id);

            if (order != null)
            {
                order.Status = OrderStatus.Processed;
                _orderRepository.Update(order);
            }
            return order;
        }

        
    }
}
