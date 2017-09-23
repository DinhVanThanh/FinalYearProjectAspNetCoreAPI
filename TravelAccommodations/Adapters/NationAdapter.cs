using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;
using TravelAccommodations.Models.ViewModels;

namespace TravelAccommodations.Adapters
{
    public static class NationAdapter
    {
        public static NationViewModel ToViewModel(this Nation model)
        {
            if (model != null)
            {
                NationViewModel viewModel = new NationViewModel();
                viewModel.Id = model.Id;
                viewModel.Name = model.Name;
                viewModel.Currency = model.Currency;
                viewModel.Unit = model.Unit;
                return viewModel;
            }
            return null;
        }

        public static Nation ToModel(this NationViewModel viewModel)
        {
            if (viewModel != null)
            {
                Nation model = new Nation();
                model.Id = viewModel.Id;
                model.Name = viewModel.Name;
                model.Unit = viewModel.Unit;
                model.Currency = viewModel.Currency;
                return model;
            }
            return null;
        }
    }
}
