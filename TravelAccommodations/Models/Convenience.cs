﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models
{
    public class Convenience
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public short? Rating { get; set; }
    }
}
