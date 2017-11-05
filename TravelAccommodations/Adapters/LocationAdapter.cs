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
                viewModel.City = model.City;
                viewModel.Province = model.Province;
                viewModel.District = model.District;
                viewModel.Ward = model.Ward;
                viewModel.Road = model.Road;
                viewModel.HouseNumber = model.HouseNumber;
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
                model.City = viewModel.City;
                model.Province = viewModel.Province;
                model.District = viewModel.District;
                model.Ward = viewModel.Ward;
                model.Road = viewModel.Road;
                model.HouseNumber = viewModel.HouseNumber;
                return model;
            }
            return null;
        }
    }
}
