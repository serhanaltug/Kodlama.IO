using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("GetByBrand")]
        public IActionResult GetByBrand(int brandId)
        {
            var result = _service.GetCarsByBrandId(brandId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("GetByColor")]
        public IActionResult GetByColor(int colorId)
        {
            var result = _service.GetCarsByColorId(colorId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("GetAllWithDetails")]
        public IActionResult GetAllWithDetails(int? brandId, int? colorId)
        {
            var result = _service.GetCarDetails(brandId, colorId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("GetCarWithDetails")]
        public IActionResult GetCarWithDetails(int id)
        {
            var result = _service.GetCar(id);
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
