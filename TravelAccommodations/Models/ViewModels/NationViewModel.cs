using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models.ViewModels
{
    public class NationViewModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int? Currency { get; set; } 
        public string Unit { get; set; }
    }
}
