using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models
{
    public class TravelAccommodationDBContext : DbContext
    {
        public TravelAccommodationDBContext() : base() { }

        DbSet<Accommodation> Accommodations { get; set; }
        DbSet<AccommodationCategory> AccommodationCategories { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<CommentGroup> CommentGroups { get; set; }
        DbSet<Convenience> Conveniences { get; set; }
        DbSet<Image> Images { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<Registration> Registrations { get; set; }
        DbSet<Room> Rooms { get; set; }
        DbSet<RoomType> RoomTypes { get; set; }
        DbSet<Service> Services { get; set; }
    }
}
