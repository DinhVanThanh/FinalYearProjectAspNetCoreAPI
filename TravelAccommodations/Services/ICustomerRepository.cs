using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAccommodations.Models;

namespace TravelAccommodations.IServices
{
    public interface ICustomerRepository : ICRUDRepository<Customer>
    {
    }
}
