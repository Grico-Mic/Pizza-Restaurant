using Pizza_Restaurant.Models;
using Pizza_Restaurant.Repositories.Interfaces;
using System.Linq;

namespace Pizza_Restaurant.Repositories
{
    public class SubcriptionRepository : ISubcriptionRepository
    {
        private readonly PizzaRestaurantDbContex _dbContext;

        public SubcriptionRepository(PizzaRestaurantDbContex dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Subscription newSubcriber)
        {
            _dbContext.Subscriptions.Add(newSubcriber);
            _dbContext.SaveChanges();
        }

        Subscription ISubcriptionRepository.GetByEmail(string email)
        {
            return _dbContext.Subscriptions.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
        }
    }
}
