using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.IServices;
using TravelAccommodations.Models;

namespace TravelAccommodations.Services
{
    public class LocationRepository : ILocationRepository
    {
        private TravelAccommodationDBContext _context;
        public LocationRepository(TravelAccommodationDBContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(Location newObject)
        {
            _context.Locations.Add(newObject);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int ObjectId)
        {
            _context.Locations.Remove(await getAsync(ObjectId));
            return await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Location>> getAllAsync()
        {
            return _context.Locations.ToList();
        }

        public async Task<Location> getAsync(int ObjectId)
        {
            return _context.Locations.SingleOrDefault(r => r.Id == ObjectId);
        }

        public async Task<Location> getAsync(string ObjectName)
        {
            return _context.Locations.SingleOrDefault(r => r.Name == ObjectName);
        }

        public async Task<int> UpdateAsync(Location updatedObject)
        {
            _context.Locations.Update(updatedObject);
            return await _context.SaveChangesAsync();
        }
    }
}
