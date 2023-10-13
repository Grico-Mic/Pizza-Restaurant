using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_Restaurant.Mapping;
using Pizza_Restaurant.Services.Interfaces;
using Pizza_Restaurant.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Pizza_Restaurant.Pages
{
    public class HomeModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        private readonly IOfferService _offerService;

        public HomeModel(IOfferService offerService)
        {
            _offerService = offerService;
        }


        public List<OfferViewModel> Offers { get; set; }
        public void OnGet()
        {
            var offers = _offerService.GetAllValid();
            Offers = offers.Select(x => x.ToViewModel()).ToList();
        }
    }
}
