using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.IServices;
using TravelAccommodations.Models;

namespace TravelAccommodations.Services
{
    public class ServiceRepository : IServiceRepository
    {
        private TravelAccommodationDBContext _context;
        public ServiceRepository(TravelAccommodationDBContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(Service newObject)
        {
            _context.Services.Add(newObject);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int ObjectId)
        {
            _context.Services.Remove(await getAsync(ObjectId));
            return await _context.SaveChangesAsync();
        }

        public async Task<Service> getAsync(int ObjectId)
        {
            return _context.Services.SingleOrDefault(s => s.Id == ObjectId);
        }

        public async Task<Service> getAsync(string ObjectName)
        {
            return _context.Services.SingleOrDefault(s => s.Name == ObjectName);
        }

        public async Task<ICollection<Service>> getAllAsync()
        {
            return _context.Services.ToList();
        }

        public async Task<int> UpdateAsync(Service updatedObject)
        {
            _context.Services.Update(updatedObject);
            return await _context.SaveChangesAsync(); 
        }
    }
}
