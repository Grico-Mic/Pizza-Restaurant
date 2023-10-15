using Pizza_Restaurant.Models;
using Pizza_Restaurant.ViewModels;

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

        public static MenuItemViewModel ToViewModel(this MenuItem entity)
        {
            return new MenuItemViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                ImageURL = entity.ImageURL,
                Descripton = entity.Description,
                Price = entity.Price,
                Currency = entity.Currency,
                Slug = entity.Slug

            };
        }

        public static OrdersListViewModel ToViewModel(this Order entity)
        {
            return new OrdersListViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Surname = entity.Surname,
                Address = entity.Address,
                Phone = entity.Phone,
                Message = entity.Message,
                Status = entity.Status
            };
        }
    }
}
