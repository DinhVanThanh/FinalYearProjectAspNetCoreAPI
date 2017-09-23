using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.IServices;
using TravelAccommodations.Models;

namespace TravelAccommodations.Services
{
    public class ConvenienceRepository : IConvenienceRepository
    {
        private TravelAccommodationDBContext _context;
        public ConvenienceRepository(TravelAccommodationDBContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(Convenience newObject)
        {
            _context.Conveniences.Add(newObject);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int ObjectId)
        {
            _context.Conveniences.Remove(await getAsync(ObjectId));
            return await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Convenience>> getAllAsync()
        {
            return _context.Conveniences.ToList();
        }

        public async Task<Convenience> getAsync(int ObjectId)
        {
            return _context.Conveniences.SingleOrDefault(r => r.Id == ObjectId);
        }

        public async Task<Convenience> getAsync(string ObjectName)
        {
            return _context.Conveniences.SingleOrDefault(r => r.Name == ObjectName);
        }

        public async Task<int> UpdateAsync(Convenience updatedObject)
        {
            _context.Conveniences.Update(updatedObject);
            return await _context.SaveChangesAsync();
        }
    }
}
