using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;
using TravelAccommodations.Models.ViewModels;

namespace TravelAccommodations.Adapters
{
    public static class RoomAdapter
    {
        public static RoomViewModel ToViewModel(this Room model)
        {
            if (model != null)
            {
                RoomViewModel viewModel = new RoomViewModel();
                viewModel.Id = model.Id;
                viewModel.AccommodationId = model.AccommodationId;
                viewModel.Capacity = model.Capacity;
                viewModel.Images = model.Images;
                viewModel.Price = model.Price;
                viewModel.RegisterId = model.RegisterId;
                viewModel.RoomTypeId = model.RoomTypeId;
                viewModel.Status = model.Status;
                
                return viewModel;
            }
            return null;
        }

        public static Room ToModel(this RoomViewModel viewModel)
        {
            if (viewModel != null)
            {
                Room model = new Room();
                model.Id = viewModel.Id;
                model.AccommodationId = viewModel.AccommodationId;
                model.Capacity = viewModel.Capacity;
                model.Images = viewModel.Images;
                model.Price = viewModel.Price;
                model.RegisterId = viewModel.RegisterId;
                model.RoomTypeId = viewModel.RoomTypeId;
                model.Status = viewModel.Status;
                return model;
            }
            return null;
        }
    }
}
