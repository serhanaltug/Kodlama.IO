using Business.Abstract;
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
    public class UsersController : ControllerBase
    {
        IUserService _service;

        public UsersController(IUserService service)
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
        public IActionResult Add(User user)
        {
            var result = _service.Add(user);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(User user)
        {
            var result = _service.Update(user);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(User user)
        {
            var result = _service.Delete(user);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

    }
}
