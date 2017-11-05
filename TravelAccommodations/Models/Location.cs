using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models
{
    public class Location
    {
        [Key]
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
