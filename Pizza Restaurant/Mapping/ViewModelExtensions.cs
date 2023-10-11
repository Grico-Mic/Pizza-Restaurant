using Pizza_Restaurant.Models;
using Pizza_Restaurant.ViewModels;

namespace Pizza_Restaurant.Mapping
{
    public static class ViewModelExtensions
    {
        public static Order ToDomainModel(this OrderViewModel entity)
        {
            return new Order()
            {
               Name = entity.Name,
               Surname = entity.Surname,
               Phone = entity.Phone,
               Address = entity.Address,
               Message = entity.Message
            };
        }
    }
}
