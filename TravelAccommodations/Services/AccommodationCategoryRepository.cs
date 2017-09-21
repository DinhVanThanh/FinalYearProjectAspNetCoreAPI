using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.IServices;
using TravelAccommodations.Models;

namespace TravelAccommodations.Services
{
    public class AccommodationCategoryRepository : IAccommodationRepository
    {
        private TravelAccommodationDBContext _context;
        public AccommodationCategoryRepository(TravelAccommodationDBContext context)
        {
            _context = context;
        }
        public int Create(Accommodation newObject)
        {
            throw new NotImplementedException();
        }

        public int Delete(int ObjectId)
        {
            throw new NotImplementedException();
        }

        public Accommodation get(int ObjectId)
        {
            throw new NotImplementedException();
        }

        public Accommodation get(string ObjectName)
        {
            throw new NotImplementedException();
        }

        public ICollection<Accommodation> getAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Accommodation updatedObject)
        {
            throw new NotImplementedException();
        }
    }
}
