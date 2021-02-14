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
    public class CarsController : ControllerBase
    {
        ICarService _service;

        public CarsController(ICarService service)
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
        public IActionResult Add(Car car)
        {
            var result = _service.Add(car);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Car car)
        {
            var result = _service.Update(car);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Car car)
        {
            var result = _service.Delete(car);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

    }
}
