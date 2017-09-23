using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.IServices;
using TravelAccommodations.Models;

namespace TravelAccommodations.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private TravelAccommodationDBContext _context;
        public CustomerRepository(TravelAccommodationDBContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(Customer newObject)
        {
            _context.Customers.Add(newObject);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int ObjectId)
        {
            _context.Customers.Remove(await getAsync(ObjectId));
            return await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Customer>> getAllAsync()
        {
            return _context.Customers.ToList();
        }

        public async Task<Customer> getAsync(int ObjectId)
        {
            return _context.Customers.SingleOrDefault(r => r.Id == ObjectId);
        }

        public async Task<Customer> getAsync(string ObjectName)
        {
            return _context.Customers.SingleOrDefault(r => r.LastName + " " + r.FirstName == ObjectName);
        }

        public async Task<int> UpdateAsync(Customer updatedObject)
        {
            _context.Customers.Update(updatedObject);
            return await _context.SaveChangesAsync();
        }
    }
}
