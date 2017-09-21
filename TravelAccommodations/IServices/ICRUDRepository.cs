using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAccommodations.IServices
{
    public interface ICRUDRepository<T>
    {
        int Create(T newObject);
        int Update(T updatedObject);
        int Delete(int ObjectId);
        ICollection<T> getAll();
        T get(int ObjectId);
        T get(string ObjectName);
    }
}
