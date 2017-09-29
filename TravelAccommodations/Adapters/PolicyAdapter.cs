using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;
using TravelAccommodations.Models.ViewModels;

namespace TravelAccommodations.Adapters
{
    public static class PolicyAdapter
    {

        public static Policy ToModel(this PolicyViewModel viewModel)
        {
            if (viewModel != null)
            {
                Policy model = new Policy();
                model.Id = viewModel.Id;
                model.Content = viewModel.Content;
                return model;
            }
            return null;
        }
        public static PolicyViewModel ToViewModel(this Policy model)
        {
            if (model != null)
            {
                PolicyViewModel viewModel = new PolicyViewModel();
                viewModel.Id = model.Id;
                viewModel.Content = model.Content;
                return viewModel;
            }
            return null;
        }
    }
}
