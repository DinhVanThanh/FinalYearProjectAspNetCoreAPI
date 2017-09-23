using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;
using TravelAccommodations.Models.ViewModels;

namespace TravelAccommodations.Adapters
{
    public static class CommentAdapter
    {
        public static Comment ToModel(this CommentViewModel viewModel)
        {
            if(viewModel != null)
            {
                Comment model = new Comment();
                model.Id = viewModel.Id;
                model.Content = viewModel.Content;
                model.CommentTypeId = viewModel.CommentTypeId;
                model.CustomerId = viewModel.CustomerId;
                return model;
            }
            return null;
        }
        public static CommentViewModel ToViewModel(this Comment model)
        {
            if (model != null)
            {
                CommentViewModel viewModel = new CommentViewModel();
                viewModel.Id = model.Id;
                viewModel.Content = model.Content;
                viewModel.CommentTypeId = model.CommentTypeId;
                viewModel.CustomerId = model.CustomerId;
                return viewModel;
            }
            return null;
        }
    }
}
