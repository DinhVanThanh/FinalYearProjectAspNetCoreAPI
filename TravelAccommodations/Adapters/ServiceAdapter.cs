using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;
using TravelAccommodations.Models.ViewModels;

namespace TravelAccommodations.Adapters
{
    public static class ServiceAdapter
    {
        public static ServiceViewModel ToViewModel(this Service model)
        {
            if (model != null)
            {
                ServiceViewModel viewModel = new ServiceViewModel();
                viewModel.Id = model.Id;
                viewModel.Name = model.Name;
                viewModel.Rating = model.Rating;
                return viewModel;
            }
            return null;
        }

        public static Service ToModel(this ServiceViewModel viewModel)
        {
            if (viewModel != null)
            {
                Service model = new Service();
                model.Id = viewModel.Id;
                model.Name = viewModel.Name;
                model.Rating = viewModel.Rating;
                return model;
            }
            return null;
        }
    }
}
