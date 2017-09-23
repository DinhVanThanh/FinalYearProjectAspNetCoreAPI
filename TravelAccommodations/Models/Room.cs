using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Enums;

namespace TravelAccommodations.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string Price { get; set; }
        public short Capacity { get; set; }
        [ForeignKey("Type")]
        public int RoomTypeId { get; set; }
        [ForeignKey("RoomTypeId")]
        public RoomType Type { get; set; }
        public RoomStatus Status { get; set; }
        public IList<Image> Images { get; set; }
        [ForeignKey("Accommodation")]
        public int AccommodationId { get; set; }
        public Accommodation Accommodation { get; set; }
        [ForeignKey("Register")]
        public int RegisterId { get; set; }
        public Registration Register { get; set; }
    }
}
