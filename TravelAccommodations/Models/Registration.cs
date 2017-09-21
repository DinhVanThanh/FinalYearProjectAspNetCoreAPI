using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public IList<Room> Rooms { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
