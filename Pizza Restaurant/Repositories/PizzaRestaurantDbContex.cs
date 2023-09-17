using Microsoft.EntityFrameworkCore;
using Pizza_Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_Restaurant.Repositories
{
    public class PizzaRestaurantDbContex : DbContext
    {
        public PizzaRestaurantDbContex(DbContextOptions<PizzaRestaurantDbContex> options) : base(options) { }
        
            public DbSet<Offer> Offers { get; set; }

        
    }
}
