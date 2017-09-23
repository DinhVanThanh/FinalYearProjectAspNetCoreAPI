using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models.ViewModels
{
    public class RegistrationViewModel
    {
        public int Id { get; set; } 
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public IList<Room> Rooms { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
