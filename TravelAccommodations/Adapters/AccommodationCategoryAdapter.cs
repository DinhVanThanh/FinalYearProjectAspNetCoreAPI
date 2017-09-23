using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;
using TravelAccommodations.Models.ViewModels;

namespace TravelAccommodations.Adapters
{
    public static class AccommodationCategoryAdapter
    {
        public static AccommodationCategory ToModel(this AccommodationCategoryViewModel viewModel)
        {
            if(viewModel != null)
            {
                AccommodationCategory model = new AccommodationCategory();
                model.Id = viewModel.Id;
                model.Name = viewModel.Name;
                return null;
            }
            return null;
        }
        public static AccommodationCategoryViewModel ToViewModel( this AccommodationCategory model)
        {
            if (model != null)
            {
                AccommodationCategoryViewModel viewModel = new AccommodationCategoryViewModel();
                viewModel.Id = model.Id;
                viewModel.Name = model.Name;
                return viewModel ;
            }
            return null;
        }
    }
}
