﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelAccommodations.IServices;
using TravelAccommodations.Models.ViewModels;
using System.Net;
using TravelAccommodations.Models;
using TravelAccommodations.Adapters;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelAccommodations.Controllers
{
    [Route("api/[controller]")]
    public class CommentGroupController : Controller
    {
        private ICommentGroupRepository _service;
        public CommentGroupController(ICommentGroupRepository service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<CommentGroupViewModel> Get(int id)
        {
            CommentGroup commentGroup = await _service.getAsync(id);
            return commentGroup.ToViewModel();
        }


        [HttpPost("Create")]
        public async Task<StatusCodeResult> Create([FromBody]CommentGroupViewModel viewModel)
        {
            if (await _service.CreateAsync(viewModel.ToModel()) == 1)
                return StatusCode((int)HttpStatusCode.OK);
            else
                return StatusCode((int)HttpStatusCode.ExpectationFailed);
        }


        [HttpPut("Update")]
        public async Task<StatusCodeResult> Update([FromBody]CommentGroupViewModel viewModel)
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
