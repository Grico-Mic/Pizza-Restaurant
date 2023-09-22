using Pizza_Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizza_Restaurant.Repositories.Interfaces
{
    public class OffersRepository : IOffersRepository
    {
        private readonly PizzaRestaurantDbContex _dbContext;

        public OffersRepository(PizzaRestaurantDbContex dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Offer> GetAllValid()
        {
            return _dbContext.Offers.Where(x => x.ValidTo.Date >= DateTime.Now.Date).ToList();
        }
    }
}
