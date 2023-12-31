﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pizza_Restaurant.Models;

namespace Pizza_Restaurant.Repositories
{
    public class PizzaRestaurantDbContex : IdentityDbContext<AplicationUser>
    {
        public PizzaRestaurantDbContex(DbContextOptions<PizzaRestaurantDbContex> options) : base(options) { }

        public DbSet<Offer> Offers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MenuItem>()
                .HasIndex(u => u.Slug)
                .IsUnique();

            base.OnModelCreating(builder);
        }
    }
}
