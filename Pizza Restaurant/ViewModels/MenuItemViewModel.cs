using System;

namespace Pizza_Restaurant.ViewModels
{
    public class MenuItemViewModel
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public string Descripton { get; set; }
        public int Price { get; set; }
        public string Currency { get; set; }
        public string Slug { get; set; }

    }
}
