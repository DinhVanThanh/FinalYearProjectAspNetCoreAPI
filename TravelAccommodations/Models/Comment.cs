using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [ForeignKey("Type")]
        public int? CommentTypeId { get; set; }
        [ForeignKey("CommentTypeId")]
        public CommentGroup Type { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public short? Rating { get; set; }
    }
}
