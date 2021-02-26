using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _service;

        public RentalsController(IRentalService service)
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
        public IActionResult Add(Rental rental)
        {
            var result = _service.Add(rental);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Rental rental)
        {
            var result = _service.Update(rental);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Rental rental)
        {
            var result = _service.Delete(rental);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

    }
}
