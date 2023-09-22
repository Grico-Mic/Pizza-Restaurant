using Pizza_Restaurant.Models;
using System.Collections.Generic;

namespace Pizza_Restaurant.Repositories.Interfaces
{
    public interface IOffersRepository
    {
        List<Offer> GetAllValid();
    }
}
