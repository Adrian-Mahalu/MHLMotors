using MHL_Motors.Models.CarDataModels;
using MHL_Motors.Services.CarServices;
using Microsoft.AspNetCore.Mvc;

namespace MHL_Motors.API.Controllers.CarManagementControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EngineController : Controller
    {
        private readonly IEngineService _engineService;

        public EngineController(IEngineService engineService)
        {
            _engineService = engineService;
        }

        [HttpGet("GetAllEnginesAsync")]
        public async Task<ActionResult<List<Engine>>> GetAllEnginesAsync()
        {
            var result = await _engineService.GetAllEnginesAsync();
            if (result is null)
            {
                return NotFound("Engines not found.");
            }
            return Ok(result);
        }

        [HttpGet("GetEngineByIdAsync")]
        public async Task<ActionResult<Engine>> GetEngineByIdAsync(Guid id)
        {
            var result = await _engineService.GetEngineByIdAsync(id);
            if (result is null)
            {
                return NotFound("Engine not found.");
            }
            return Ok(result);
        }

        [HttpGet("GetEnginesByGenerationNameAsync/{generationName}")]
        public async Task<ActionResult<Engine>> GetEnginesByGenerationNameAsync(string generationName)
        {
            var result = await _engineService.GetEnginesByGenerationNameAsync(generationName);
            if (result is null)
            {
                return NotFound("Engines not found.");
            }
            return Ok(result);
        }
    }
}
