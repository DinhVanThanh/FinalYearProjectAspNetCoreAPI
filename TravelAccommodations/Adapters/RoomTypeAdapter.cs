using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;
using TravelAccommodations.Models.ViewModels;

namespace TravelAccommodations.Adapters
{
    public static class RoomTypeAdapter
    {
        public static RoomTypeViewModel ToViewModel(this RoomType model)
        {
            if (model != null)
            {
                RoomTypeViewModel viewModel = new RoomTypeViewModel();
                viewModel.Id = model.Id;
                viewModel.Name = model.Name;
                return viewModel;
            }
            return null;
        }

        public static RoomType ToModel(this RoomTypeViewModel viewModel)
        {
            if (viewModel != null)
            {
                RoomType model = new RoomType();
                model.Id = viewModel.Id;
                model.Name = viewModel.Name;
                return model;
            }
            return null;
        }
    }
}
