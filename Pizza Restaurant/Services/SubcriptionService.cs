using Pizza_Restaurant.Models;
using Pizza_Restaurant.Repositories.Interfaces;
using Pizza_Restaurant.Services.Interfaces;
using System;

namespace Pizza_Restaurant.Services
{
    public class SubcriptionService : ISubcriptionService
    {
        private readonly ISubcriptionRepository _subcriptionRepository;
        
        public SubcriptionService(ISubcriptionRepository subcriptionRepository)
        {
            _subcriptionRepository = subcriptionRepository;
        }
        public void Create(string email)
        {
            var existingSubscriber = _subcriptionRepository.GetByEmail(email);

            if (existingSubscriber == null)
            {
                var newSubcriber = new Subscription()
                {
                    Email = email,
                    DateCreated = DateTime.Now
                };
                _subcriptionRepository.Add(newSubcriber);
            }
        }
    }
}
