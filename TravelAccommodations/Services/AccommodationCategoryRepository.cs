using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.IServices;
using TravelAccommodations.Models;

namespace TravelAccommodations.Services
{
    public class AccommodationCategoryRepository : IAccommodationCategoryRepository
    {
        private TravelAccommodationDBContext _context;
        public AccommodationCategoryRepository(TravelAccommodationDBContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(AccommodationCategory newObject)
        {
            _context.AccommodationCategories.Add(newObject);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int ObjectId)
        {
            _context.AccommodationCategories.Remove(await getAsync(ObjectId));
            return await _context.SaveChangesAsync();
        }

        public async Task<ICollection<AccommodationCategory>> getAllAsync()
        {
            return _context.AccommodationCategories.ToList();
        }

        public async Task<AccommodationCategory> getAsync(int ObjectId)
        {
            return _context.AccommodationCategories.SingleOrDefault(r => r.Id == ObjectId);
        }

        public async Task<AccommodationCategory> getAsync(string ObjectName)
        {
            return _context.AccommodationCategories.SingleOrDefault(r => r.Name == ObjectName);
        }

        public async Task<int> UpdateAsync(AccommodationCategory updatedObject)
        {
            _context.AccommodationCategories.Update(updatedObject);
            return await _context.SaveChangesAsync();
        }
    }
}
