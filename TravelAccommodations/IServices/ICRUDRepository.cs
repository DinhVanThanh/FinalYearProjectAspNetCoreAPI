using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.IServices
{
    public interface ICRUDRepository<T>
    {
        Task<int> CreateAsync(T newObject);
        Task<int> UpdateAsync(T updatedObject);
        Task<int> DeleteAsync(int ObjectId);
        Task<ICollection<T>> getAllAsync();
        Task<T> getAsync(int ObjectId); 
    }
}
