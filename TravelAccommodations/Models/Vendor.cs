using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models
{
    public class Vendor
    {
        [Key]
        public int Id { get; set; }
        public string Owner { get; set; }
        public string CompanyName { get; set; } 
        public string OfficialAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BusinessCode { get; set; }
        public Boolean IsActive { get; set; }
        public IList<Accommodation> Accommodations { get; set; }
    }
}
