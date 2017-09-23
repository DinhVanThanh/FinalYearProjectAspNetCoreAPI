
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;
using TravelAccommodations.Models.ViewModels;

namespace TravelAccommodations.Adapters
{
    public static class CustomerAdapter
    {
        public static CustomerViewModel ToViewModel(this Customer model)
        {
            if (model != null)
            {
                CustomerViewModel viewModel = new CustomerViewModel();
                viewModel.Id = model.Id;
                viewModel.Address = model.Address;
                viewModel.DateOfBirth = model.DateOfBirth;
                viewModel.Email = model.Email;
                viewModel.FirstName = model.FirstName;
                viewModel.Gender = model.Gender;
                viewModel.IdentityNumber = model.IdentityNumber;
                viewModel.LastName = model.LastName;
                viewModel.Nation = model.Nation;
                viewModel.PhoneNumber = model.PhoneNumber;
                
                return viewModel;
            }
            return null;
        }

        public static Customer ToModel(this CustomerViewModel viewModel)
        {
            if (viewModel != null)
            {
                Customer model = new Customer();
                model.Id = viewModel.Id;
                model.Address = viewModel.Address;
                model.DateOfBirth = viewModel.DateOfBirth;
                model.Email = viewModel.Email;
                model.FirstName = viewModel.FirstName;
                model.Gender = viewModel.Gender;
                model.IdentityNumber = viewModel.IdentityNumber;
                model.LastName = viewModel.LastName;
                model.Nation = viewModel.Nation;
                model.PhoneNumber = viewModel.PhoneNumber;
                return model;
            }
            return null;
        }
    }
}
