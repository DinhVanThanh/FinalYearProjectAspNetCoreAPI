using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;
using TravelAccommodations.Models.ViewModels;

namespace TravelAccommodations.Adapters
{
    public static class VendorAdapter
    {
        public static Vendor ToModel(this VendorViewModel viewModel)
        {
            if (viewModel != null)
            {
                Vendor model = new Vendor();
                model.Id = viewModel.Id;
                model.Owner = viewModel.Owner;
                model.CompanyName = viewModel.CompanyName;
                model.Email = viewModel.Email;
                model.OfficialAddress = viewModel.OfficialAddress;
                model.BusinessCode = viewModel.BusinessCode;
                model.PhoneNumber = viewModel.PhoneNumber;
                model.IsActive = viewModel.IsActive;
                return model;
            }
            return null;
        }

        public static VendorViewModel ToViewModel(this Vendor model)
        {
            if (model != null)
            {
                VendorViewModel viewModel = new VendorViewModel();
                viewModel.Id = model.Id;
                viewModel.Id = model.Id;
                viewModel.Owner = model.Owner;
                viewModel.CompanyName = model.CompanyName;
                viewModel.Email = model.Email;
                viewModel.OfficialAddress = model.OfficialAddress;
                viewModel.BusinessCode = model.BusinessCode;
                viewModel.PhoneNumber = model.PhoneNumber;
                viewModel.IsActive = model.IsActive;
                return viewModel;
            }
            return null;
        }
    }
}
