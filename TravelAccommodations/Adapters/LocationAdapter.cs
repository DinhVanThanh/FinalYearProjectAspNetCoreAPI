using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;
using TravelAccommodations.Models.ViewModels;

namespace TravelAccommodations.Adapters
{
    public static class LocationAdapter
    {
        public static LocationViewModel ToViewModel(this Location model)
        {
            if (model != null)
            {
                LocationViewModel viewModel = new LocationViewModel();
                viewModel.Id = model.Id;
                viewModel.Name = model.Name;
                viewModel.Address = model.Address;
                return viewModel;
            }
            return null;
        }

        public static Location ToModel(this LocationViewModel viewModel)
        {
            if (viewModel != null)
            {
                Location model = new Location();
                model.Id = viewModel.Id;
                model.Name = viewModel.Name;
                model.Address = viewModel.Address;
                return model;
            }
            return null;
        }
    }
}
