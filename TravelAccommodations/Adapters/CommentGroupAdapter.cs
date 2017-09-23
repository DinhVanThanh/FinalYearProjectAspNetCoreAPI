using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;
using TravelAccommodations.Models.ViewModels;

namespace TravelAccommodations.Adapters
{
    public static class CommentGroupAdapter
    {
        public static CommentGroupViewModel ToViewModel(this CommentGroup model)
        {
            if(model != null)
            {
                CommentGroupViewModel viewModel = new CommentGroupViewModel();
                viewModel.Id = model.Id;
                viewModel.Name = model.Name;
                return viewModel;
            }
            return null;
        }

        public static CommentGroup ToModel(this CommentGroupViewModel viewModel)
        {
            if (viewModel != null)
            {
                CommentGroup model = new CommentGroup();
                model.Id = viewModel.Id;
                model.Name = viewModel.Name;
                return model;
            }
            return null;
        }
    }
}
