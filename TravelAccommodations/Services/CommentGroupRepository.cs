using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.IServices;
using TravelAccommodations.Models;

namespace TravelAccommodations.Services
{
    public class CommentGroupRepository : ICommentGroupRepository
    {
        private TravelAccommodationDBContext _context;
        public CommentGroupRepository(TravelAccommodationDBContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(CommentGroup newObject)
        {
            _context.CommentGroups.Add(newObject);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int ObjectId)
        {
            _context.CommentGroups.Remove(await getAsync(ObjectId));
            return await _context.SaveChangesAsync();
        }

        public async Task<ICollection<CommentGroup>> getAllAsync()
        {
            return _context.CommentGroups.ToList();
        }

        public async Task<CommentGroup> getAsync(int ObjectId)
        {
            return _context.CommentGroups.SingleOrDefault(r => r.Id == ObjectId);
        }

        public async Task<CommentGroup> getAsync(string ObjectName)
        {
            return _context.CommentGroups.SingleOrDefault(r => r.Name == ObjectName);
        }

        public async Task<int> UpdateAsync(CommentGroup updatedObject)
        {
            _context.CommentGroups.Update(updatedObject);
            return await _context.SaveChangesAsync();
        }
    }
}
