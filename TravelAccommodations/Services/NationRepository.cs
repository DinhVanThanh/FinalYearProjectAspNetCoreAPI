using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.IServices;
using TravelAccommodations.Models;

namespace TravelAccommodations.Services
{
    public class NationRepository : INationRepository
    {
        private TravelAccommodationDBContext _context;
        public NationRepository(TravelAccommodationDBContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(Nation newObject)
        {
            _context.Nations.Add(newObject);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int ObjectId)
        {
            _context.Nations.Remove(await getAsync(ObjectId));
            return await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Nation>> getAllAsync()
        {
            return _context.Nations.ToList();
        }

        public async Task<Nation> getAsync(int ObjectId)
        {
            return _context.Nations.SingleOrDefault(n => n.Id == ObjectId);
        }

        public async Task<Nation> getAsync(string ObjectName)
        {
            return _context.Nations.SingleOrDefault(n => n.Name == ObjectName);
        }

        public async Task<int> UpdateAsync(Nation updatedObject)
        {
            _context.Nations.Update(updatedObject);
            return await _context.SaveChangesAsync();
        }
    }
}
