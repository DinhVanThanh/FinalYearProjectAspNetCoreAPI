using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;
using TravelAccommodations.Models.ViewModels;

namespace TravelAccommodations.Adapters
{
    public static class ConvenienceAdapter
    {
        public static ConvenienceViewModel ToViewModel(this Convenience model)
        {
            if (model != null)
            {
                ConvenienceViewModel viewModel = new ConvenienceViewModel();
                viewModel.Id = model.Id;
                viewModel.Name = model.Name;
                viewModel.Rating = model.Rating;
                return viewModel;
            }
            return null;
        }

        public static Convenience ToModel(this ConvenienceViewModel viewModel)
        {
            if (viewModel != null)
            {
                Convenience model = new Convenience();
                model.Id = viewModel.Id;
                model.Name = viewModel.Name;
                model.Rating = viewModel.Rating;
                return model;
            }
            return null;
        }
    }
}
