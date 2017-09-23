using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.IServices;
using TravelAccommodations.Models;

namespace TravelAccommodations.Services
{
    public class RoomRepository : IRoomRepository
    {
        private TravelAccommodationDBContext _context;
        public RoomRepository(TravelAccommodationDBContext context)
        {
            _context = context;
        }
       public async Task<int> CreateAsync(Room newObject)
        {
            _context.Rooms.Add(newObject);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int ObjectId)
        {
            _context.Rooms.Remove(await getAsync(ObjectId));
            return await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Room>> getAllAsync()
        {
            return _context.Rooms.ToList();
        }

        public async Task<Room> getAsync(int ObjectId)
        {
            return _context.Rooms.SingleOrDefault(r => r.Id == ObjectId);
        }

         

        public async Task<int> UpdateAsync(Room updatedObject)
        {
            _context.Rooms.Update(updatedObject);
            return await _context.SaveChangesAsync();
        }
    }
}
