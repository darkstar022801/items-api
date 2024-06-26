﻿using Items.Common.DTOs;
using Items.Service.Item.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Items.Controllers
{
    [AllowAnonymous]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class SubItemController : ControllerBase
    {
        private readonly ILogger<SubItemController> _logger;
        private readonly ISubItem _subItemService;

        public SubItemController(ILogger<SubItemController> logger, ISubItem subItemService)
        {
            _logger = logger;
            _subItemService = subItemService;
        }

        [HttpGet, Route("test")]
        public ActionResult<string> Test()
        {
            return Ok("SubItemController");
        }

        //[HttpGet, Route("GetAll")]
        //public ActionResult<IAsyncEnumerable<SubItemDTO>> GetAll()
        //{
        //    IAsyncEnumerable<SubItemDTO> list = _subItemService.GetAllAsync();

        //    return Ok(list);
        //}

        //[HttpGet, Route("GetById/{id}")]
        //public ActionResult<IAsyncEnumerable<SubItemDTO>> GetById(Guid id)
        //{
        //    IAsyncEnumerable<SubItemDTO> subItem = _subItemService.GetByIdAsync(id);

        //    return Ok(subItem);
        //}


        //[HttpPost, Route("Create")]
        //public async Task<ActionResult> Create([FromBody] SubItemDTO subItemDTO)
        //{
        //    Guid id = await _subItemService.CreateAsync(subItemDTO);

        //    if (id == Guid.Empty)
        //        return StatusCode(303);

        //    return Created(
        //        new Uri(
        //            string.Concat(Request.Path.ToString().Remove(Request.Path.ToString().Length - 6, 6), $"GetById/{id}"),
        //            UriKind.Relative),
        //        id);
        //}
    }
}