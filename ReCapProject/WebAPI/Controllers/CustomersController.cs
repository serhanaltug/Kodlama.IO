﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _service;

        public CustomersController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll() 
        {
            var result = _service.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _service.Get(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(Customer customer)
        {
            var result = _service.Add(customer);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Customer customer)
        {
            var result = _service.Update(customer);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _service.Delete(customer);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

    }
}
