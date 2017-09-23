using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models
{
    public class Nation
    { 
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int? Currency { get; set; }
        [MaxLength(50)]
        public string Unit { get; set; }
    }
}
