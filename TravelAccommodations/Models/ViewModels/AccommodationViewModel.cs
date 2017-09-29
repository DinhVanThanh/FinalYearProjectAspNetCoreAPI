using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models.ViewModels
{
    public class AccommodationViewModel
    {
         
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? LocationId { get; set; }
        public Location Position { get; set; }
        public string AveragePrice { get; set; }
        public short? Rating { get; set; } 
        public int? TypeId { get; set; }
        public AccommodationCategory Type { get; set; }
        public IList<Image> Images { get; set; }
        public IList<Service> Services { get; set; }
        public IList<Convenience> Conveniences { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<Room> Rooms { get; set; }
        public IList<Policy> Policies { get; set; }
        public short? LocationAssessment { get; set; }
        public short? SanitaryConditionsAssessment { get; set; }
        public short? ServiceAssessment { get; set; }
        public short? ConvenientAssessment { get; set; }
        public short? RoomQualityAndComfortAssessment { get; set; }
        public short? CostAssessment { get; set; }
    }
}
