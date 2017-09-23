using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models.ViewModels
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
         
        public int? CommentTypeId { get; set; }
        
        public CommentGroup Type { get; set; }
         
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
