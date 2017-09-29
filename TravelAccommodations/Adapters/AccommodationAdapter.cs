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
                model.Description = viewModel.Description;
                model.Policies = viewModel.Policies;
                model.LocationAssessment = viewModel.LocationAssessment;
                model.SanitaryConditionsAssessment = viewModel.SanitaryConditionsAssessment;
                model.ServiceAssessment = viewModel.ServiceAssessment;
                model.RoomQualityAndComfortAssessment = viewModel.RoomQualityAndComfortAssessment;
                model.CostAssessment = viewModel.CostAssessment;
                model.ConvenientAssessment = viewModel.ConvenientAssessment;
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
                viewModel.Description = model.Description;
                viewModel.Policies = model.Policies;
                viewModel.LocationAssessment = model.LocationAssessment;
                viewModel.SanitaryConditionsAssessment = model.SanitaryConditionsAssessment;
                viewModel.ServiceAssessment = model.ServiceAssessment;
                viewModel.RoomQualityAndComfortAssessment = model.RoomQualityAndComfortAssessment;
                viewModel.CostAssessment = model.CostAssessment;
                viewModel.ConvenientAssessment = model.ConvenientAssessment;
                return viewModel;
            }
            return null;
        }
    }
}
