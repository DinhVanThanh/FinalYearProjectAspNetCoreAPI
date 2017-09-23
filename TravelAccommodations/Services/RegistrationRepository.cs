using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.IServices;
using TravelAccommodations.Models;

namespace TravelAccommodations.Services
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private TravelAccommodationDBContext _context;
        public RegistrationRepository(TravelAccommodationDBContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(Registration newObject)
        {
            _context.Registrations.Add(newObject);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int ObjectId)
        {
            _context.Registrations.Remove(await getAsync(ObjectId));
            return await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Registration>> getAllAsync()
        {
            return _context.Registrations.ToList();
        }

        public async Task<Registration> getAsync(int ObjectId)
        {
            return _context.Registrations.SingleOrDefault(r => r.Id == ObjectId);
        }
 

        public async Task<int> UpdateAsync(Registration updatedObject)
        {
            _context.Registrations.Update(updatedObject);
            return await _context.SaveChangesAsync();
        }
    }
}
