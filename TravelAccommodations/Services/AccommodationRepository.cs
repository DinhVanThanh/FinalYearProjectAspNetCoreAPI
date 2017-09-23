using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.IServices;
using TravelAccommodations.Models;

namespace TravelAccommodations.Services
{
    public class AccommodationRepository : IAccommodationRepository
    {
        private TravelAccommodationDBContext _context;
        public AccommodationRepository(TravelAccommodationDBContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(Accommodation newObject)
        {
            _context.Accommodations.Add(newObject);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int ObjectId)
        {
            _context.Accommodations.Remove(await getAsync(ObjectId));
            return await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Accommodation>> getAllAsync()
        {
            return _context.Accommodations.ToList();
        }

        public async Task<Accommodation> getAsync(int ObjectId)
        {
            return _context.Accommodations.SingleOrDefault(r => r.Id == ObjectId);
        }

        public async Task<Accommodation> getAsync(string ObjectName)
        {
            return _context.Accommodations.SingleOrDefault(r => r.Name == ObjectName);
        }

        public async Task<int> UpdateAsync(Accommodation updatedObject)
        {
            _context.Accommodations.Update(updatedObject);
            return await _context.SaveChangesAsync();
        }
    }
}
