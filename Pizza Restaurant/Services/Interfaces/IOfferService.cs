using Pizza_Restaurant.Models;
using System.Collections.Generic;

namespace Pizza_Restaurant.Services.Interfaces
{
    public interface IOfferService
    {
        List<Offer> GetAllValid();
    }
}
