using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models.ViewModels
{
    public class LocationViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string Road { get; set; }
        public string HouseNumber { get; set; }
    }
}
