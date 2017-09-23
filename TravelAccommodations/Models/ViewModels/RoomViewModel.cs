using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Enums;

namespace TravelAccommodations.Models.ViewModels
{
    public class RoomViewModel
    {
        public int Id { get; set; }
        public string Price { get; set; }
        public short? Capacity { get; set; }
        
        public int? RoomTypeId { get; set; }
         
        public RoomType Type { get; set; }
        public RoomStatus? Status { get; set; }
        public IList<Image> Images { get; set; }
         
        public int? AccommodationId { get; set; }
        public Accommodation Accommodation { get; set; }
        
        public int? RegisterId { get; set; }
        public Registration Register { get; set; }
    }
}
