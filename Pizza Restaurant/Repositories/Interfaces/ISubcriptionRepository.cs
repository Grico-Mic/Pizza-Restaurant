using Pizza_Restaurant.Models;

namespace Pizza_Restaurant.Repositories.Interfaces
{
    public interface ISubcriptionRepository
    {
        void Add(Subscription newSubcriber);
        Subscription GetByEmail(string email);
    }
}
