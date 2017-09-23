
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;
using TravelAccommodations.Models.ViewModels;

namespace TravelAccommodations.Adapters
{
    public static class RegistrationAdapter
    {
        public static RegistrationViewModel ToViewModel(this Registration model)
        {
            if (model != null)
            {
                RegistrationViewModel viewModel = new RegistrationViewModel();
                viewModel.Id = model.Id;
                viewModel.CustomerId = model.CustomerId;
                viewModel.DateFrom = model.DateFrom;
                viewModel.DateTo = model.DateTo;
                viewModel.Rooms = model.Rooms;
                
                return viewModel;
            }
            return null;
        }

        public static Registration ToModel(this RegistrationViewModel viewModel)
        {
            if (viewModel != null)
            {
                Registration model = new Registration();
                model.Id = viewModel.Id;
                model.CustomerId = viewModel.CustomerId;
                model.DateFrom = viewModel.DateFrom;
                model.DateTo = viewModel.DateTo;
                model.Rooms = viewModel.Rooms;
                return model;
            }
            return null;
        }
    }
}
