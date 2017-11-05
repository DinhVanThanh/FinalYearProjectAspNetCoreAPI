using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models.ViewModels
{
    public class VendorViewModel
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public string CompanyName { get; set; }
        public string OfficialAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BusinessCode { get; set; }
        public Boolean IsActive { get; set; }
    }
}
