using Pizza_Restaurant.Models;


namespace Pizza_Restaurant.Services.Interfaces
{
    public interface IOrderService
    {
        void Create(Order newOrder);
    }
}
