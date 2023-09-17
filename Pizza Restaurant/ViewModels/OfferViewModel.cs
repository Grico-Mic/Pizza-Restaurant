using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_Restaurant.ViewModels
{
    public class OfferViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
