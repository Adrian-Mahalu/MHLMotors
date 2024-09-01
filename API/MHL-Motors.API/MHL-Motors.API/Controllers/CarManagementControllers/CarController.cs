using MHL_Motors.Models.CarDataModels;
using MHL_Motors.Services.CarServices;
using Microsoft.AspNetCore.Mvc;

namespace MHL_Motors.API.Controllers.CarsManagementControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetAllCarsAsync")]
        public async Task<ActionResult<List<Car>>> GetAllCarsAsync()
        {
            var result = await _carService.GetAllCarsAsync();
            if (result is null)
            {
                return NotFound("Cars not found.");
            }
            return Ok(result);
        }

        [HttpGet("GetCarByIdAsync/{id}")]
        public async Task<ActionResult<Car>> GetCarByIdAsync(Guid id)
        {
            var result = await _carService.GetCarByIdAsync(id);
            if (result is null)
            {
                return NotFound("Car not found.");
            }
            return Ok(result);
        }

        [HttpPost("AddCarAdAsync")]
        public async Task<ActionResult> AddCarAdAsync([FromBody] CarAd carAd)
        {
            await _carService.AddCarAdAsync(carAd);
            return Ok(carAd);
        }

        [HttpPost("AddCarsAsync")]
        public async Task<ActionResult> AddCarsAsync()
        {
            await _carService.AddCarsAsync();
            return Ok("Cars added successfully.");
        }

        [HttpPut("UpdateCarAsync")]
        public async Task<ActionResult<List<Car>>> UpdateCarAsync(Car car)
        {
            await _carService.UpdateCarAsync(car);
            return Ok("Car updated successfully.");
        }

        [HttpDelete("DeleteCarByIdAsync")]
        public async Task<ActionResult<List<Car>>> DeleteCarByIdAsync(Guid id)
        {
            await _carService.DeleteCarByIdAsync(id);

            return Ok("Car deleted successfully.");
        }
    }
}
