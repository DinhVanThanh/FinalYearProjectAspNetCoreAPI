using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.IServices;
using TravelAccommodations.Models;

namespace TravelAccommodations.Services
{
    public class RoomTypeRepository : IRoomTypeRepository
    {
        private TravelAccommodationDBContext _context;

        public RoomTypeRepository(TravelAccommodationDBContext context)
        {
            _context = context;
        }

        public async Task<int> CreateAsync(RoomType newObject)
        {
            _context.RoomTypes.Add(newObject);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int ObjectId)
        {
            _context.RoomTypes.Remove(await getAsync(ObjectId));
            return await _context.SaveChangesAsync();
        }

        public async Task<ICollection<RoomType>> getAllAsync()
        {
            return _context.RoomTypes.ToList();
        }

        public async Task<RoomType> getAsync(int ObjectId)
        {
            return _context.RoomTypes.SingleOrDefault(r => r.Id == ObjectId);
        }

        public async Task<RoomType> getAsync(string ObjectName)
        {
            return _context.RoomTypes.SingleOrDefault(r => r.Name == ObjectName);
        }

        public async Task<int> UpdateAsync(RoomType updatedObject)
        {
            _context.RoomTypes.Update(updatedObject);
            return await _context.SaveChangesAsync();
        }
    }
}
