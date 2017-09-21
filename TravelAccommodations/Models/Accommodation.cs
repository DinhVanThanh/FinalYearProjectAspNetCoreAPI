using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models
{
    public class Accommodation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Position")]
        public int LocationId { get; set; }
        public Location Position { get; set; }
        public string AveragePrice { get; set; }
        public short Rating { get; set; }
        [ForeignKey("Type")]
        public int TypeId { get; set; }
        public AccommodationCategory Type { get; set; }
        public IList<Image> Images { get; set; } 
        public IList<Service> Services { get; set; }
        public IList<Convenience> Conveniences { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<Room> Rooms { get; set; }
    }
}
