using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.Models
{
    public class TravelAccommodationDBContext : DbContext
    {
        public TravelAccommodationDBContext() { }
        public TravelAccommodationDBContext(DbContextOptions<TravelAccommodationDBContext> options) : base(options)
        {
        }
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<AccommodationCategory> AccommodationCategories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentGroup> CommentGroups { get; set; }
        public DbSet<Convenience> Conveniences { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Nation> Nations { get; set; }
        public DbSet<Policy> Policies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public static void UpdateDatabase(IApplicationBuilder app)
        {

            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TravelAccommodationDBContext>();
            context.Database.MigrateAsync();
        }

    }
}
