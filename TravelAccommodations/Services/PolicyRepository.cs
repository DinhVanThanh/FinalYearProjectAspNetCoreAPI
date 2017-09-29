using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.IServices;
using TravelAccommodations.Models;

namespace TravelAccommodations.Services
{
    public class PolicyRepository : IPolicyRepository
    {
        private TravelAccommodationDBContext _context;
        public PolicyRepository(TravelAccommodationDBContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(Policy newObject)
        {
            _context.Policies.Add(newObject);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int ObjectId)
        {
            _context.Policies.Remove(await getAsync(ObjectId));
            return await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Policy>> getAllAsync()
        {
            return _context.Policies.ToList();
        }

        public async Task<Policy> getAsync(int ObjectId)
        {
            return _context.Policies.SingleOrDefault(r => r.Id == ObjectId);
        }

        public async Task<Policy> getAsync(string Content)
        {
            return _context.Policies.SingleOrDefault(r => r.Content.Contains(Content));
        }

        public async Task<int> UpdateAsync(Policy updatedObject)
        {
            _context.Policies.Update(updatedObject);
            return await _context.SaveChangesAsync();
        }
    }
}
