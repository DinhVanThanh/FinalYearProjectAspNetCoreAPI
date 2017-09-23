using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;
using TravelAccommodations.Models.ViewModels;

namespace TravelAccommodations.Adapters
{
    public static class AccommodationAdapter
    {
        public static Accommodation ToModel(this AccommodationViewModel viewModel)
        {
            if(viewModel != null)
            {
                Accommodation model = new Accommodation();
                model.Id = viewModel.Id;
                model.AveragePrice = viewModel.AveragePrice;
                model.Comments = viewModel.Comments;
                model.Conveniences = viewModel.Conveniences;
                model.Images = viewModel.Images;
                model.LocationId = viewModel.LocationId;
                model.Name = viewModel.Name;
                model.Rating = viewModel.Rating;
                model.Rooms = viewModel.Rooms;
                model.Services = viewModel.Services;
                model.TypeId = model.TypeId;
                return model;
            }
            return null;
        }

        public static AccommodationViewModel ToViewModel(this Accommodation model)
        {
            if (model != null)
            {
                AccommodationViewModel viewModel = new AccommodationViewModel();
                viewModel.Id = model.Id;
                viewModel.AveragePrice = model.AveragePrice;
                viewModel.Comments = model.Comments;
                viewModel.Conveniences = model.Conveniences;
                viewModel.Images = model.Images;
                viewModel.LocationId = model.LocationId;
                viewModel.Name = model.Name;
                viewModel.Rating = model.Rating;
                viewModel.Rooms = model.Rooms;
                viewModel.Services = model.Services;
                viewModel.TypeId = model.TypeId;
                return viewModel;
            }
            return null;
        }
    }
}
