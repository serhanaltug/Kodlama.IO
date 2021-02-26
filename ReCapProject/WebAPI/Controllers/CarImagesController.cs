using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _service;
        protected readonly string imageDirectory = @"wwwroot\images";

        public CarImagesController(ICarImageService service)
        {
            _service = service;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(int carId) 
        {
            var result = _service.GetAll(carId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(int carId, IFormFile imageFile)
        {
            try
            {
                if (imageFile != null && imageFile.Length > 0)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                    string filePath = Path.Combine(Directory.GetCurrentDirectory(), imageDirectory, fileName);
                    //if (!Directory.Exists(imageDirectory)) Directory.CreateDirectory(imageDirectory);

                    var result = _service.Add(new CarImage() { CarId = carId, ImagePath = fileName });
                    if (result.Success)
                    {
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            imageFile.CopyTo(fileStream);
                        }

                        return Ok(result);
                    }

                    return BadRequest(result);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return BadRequest();
        }

        [HttpPost("Update")]
        public IActionResult Update(int id, int carId, IFormFile imageFile)
        {

            if (imageFile != null && imageFile.Length > 0)
            {
                var image = _service.GetAll(carId).Data.Where(x => x.Id == id).FirstOrDefault();

                string fileName = image.ImagePath;
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), imageDirectory, fileName);
                System.IO.File.Delete(filePath);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    imageFile.CopyTo(fileStream);
                }

                image.Date = DateTime.Now;
                var result = _service.Update(image);
                if (result.Success)
                    return Ok(result);
                return BadRequest(result);
            }

            return BadRequest();
        }

        [HttpPost("Delete")]
        public IActionResult Delete(int id, int carId)
        {
            var image = _service.GetAll(carId).Data.Where(x => x.Id == id).FirstOrDefault();

            string fileName = image.ImagePath;
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), imageDirectory, fileName);
            System.IO.File.Delete(filePath);

            var result = _service.Delete(image);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

    }
}
