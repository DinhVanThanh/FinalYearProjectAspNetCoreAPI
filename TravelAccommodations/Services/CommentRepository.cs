using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.IServices;
using TravelAccommodations.Models;

namespace TravelAccommodations.Services
{
    public class CommentRepository : ICommentRepository
    {
        private TravelAccommodationDBContext _context;
        public CommentRepository(TravelAccommodationDBContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(Comment newObject)
        {
            _context.Comments.Add(newObject);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int ObjectId)
        {
            _context.Comments.Remove(await getAsync(ObjectId));
            return await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Comment>> getAllAsync()
        {
            return _context.Comments.ToList();
        }

        public async Task<Comment> getAsync(int ObjectId)
        {
            return _context.Comments.SingleOrDefault(r => r.Id == ObjectId);
        }
         

        public async Task<int> UpdateAsync(Comment updatedObject)
        {
            _context.Comments.Update(updatedObject);
            return await _context.SaveChangesAsync();
        }
    }
}
