using Pizza_Restaurant.Models;
using Pizza_Restaurant.Repositories.Interfaces;
using Pizza_Restaurant.Services.Interfaces;
using System.Collections.Generic;

namespace Pizza_Restaurant.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOffersRepository _offersRepository;

        public OfferService(IOffersRepository offersRepository)
        {
            _offersRepository = offersRepository;
        }
        public List<Offer> GetAllValid()
        {
            return _offersRepository.GetAllValid();
        }
    }
}
