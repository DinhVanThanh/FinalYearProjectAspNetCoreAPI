﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelAccommodations.Models;

namespace TravelAccommodations.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet("getAllLocation")]
        public IEnumerable<Location> Get()
        {
            return new List<Location>(){ new Location() {  }};
        }

        // GET api/values/5
        [HttpGet]
        public Location Get([FromQuery]int id)
        {
            return new Location() {};
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
