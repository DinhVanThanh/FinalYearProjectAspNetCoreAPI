﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelAccommodations.IServices;
using TravelAccommodations.Models.ViewModels;
using TravelAccommodations.Models;
using TravelAccommodations.Adapters;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelAccommodations.Controllers
{
    [Route("api/[controller]")]
    public class PolicyController : Controller
    {
        private IPolicyRepository _service;
        public PolicyController(IPolicyRepository service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<PolicyViewModel> Get(int id)
        {
            Policy policy = await _service.getAsync(id);
            return policy.ToViewModel();
        }


        [HttpPost("Create")]
        public async Task<StatusCodeResult> Create([FromBody]PolicyViewModel viewModel)
        {
            if (await _service.CreateAsync(viewModel.ToModel()) == 1)
                return StatusCode((int)HttpStatusCode.OK);
            else
                return StatusCode((int)HttpStatusCode.ExpectationFailed);
        }


        [HttpPut("Update")]
        public async Task<StatusCodeResult> Update([FromBody]PolicyViewModel viewModel)
        {
            if (await _service.UpdateAsync(viewModel.ToModel()) == 1)
                return StatusCode((int)HttpStatusCode.OK);
            else
                return StatusCode((int)HttpStatusCode.ExpectationFailed);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<StatusCodeResult> Delete(int id)
        {
            if (await _service.DeleteAsync(id) == 1)
                return StatusCode((int)HttpStatusCode.OK);
            else
                return StatusCode((int)HttpStatusCode.ExpectationFailed);
        }
    }
}
