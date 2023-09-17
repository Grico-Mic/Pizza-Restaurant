using Pizza_Restaurant.Models;
using Pizza_Restaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_Restaurant.Mapping
{
    public static class DomainViewExtensions
    {
        public static OfferViewModel ToViewModel(this Offer entity)
        {
            return new OfferViewModel()
            {
                Title = entity.Title,
                Description = entity.Description,
                ValidTo = entity.ValidTo
            };
        }
    }
}
