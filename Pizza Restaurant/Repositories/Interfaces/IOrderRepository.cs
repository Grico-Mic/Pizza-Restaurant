using Pizza_Restaurant.Models;


namespace Pizza_Restaurant.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void Create(Order newOrder);
    }
}
