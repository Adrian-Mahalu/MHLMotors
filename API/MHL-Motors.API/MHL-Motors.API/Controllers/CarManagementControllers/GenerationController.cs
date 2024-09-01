using MHL_Motors.Models.CarDataModels;
using MHL_Motors.Services.CarServices;
using Microsoft.AspNetCore.Mvc;

namespace MHL_Motors.API.Controllers.CarManagementControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerationController : Controller
    {
        private readonly IGenerationService _generationService;

        public GenerationController(IGenerationService generationService)
        {
            _generationService = generationService;
        }

        [HttpGet("GetAllGenerationsAsync")]
        public async Task<ActionResult<List<Generation>>> GetAllGenerationsAsync()
        {
            var result = await _generationService.GetAllGenerationsAsync();

            if (result is null)
            {
                return NotFound("Generations not found.");
            }
            return Ok(result);
        }

        [HttpGet("GetGenerationsByModelNameAsync/{modelName}")]
        public async Task<ActionResult<List<Generation>>> GetGenerationsByModelNameAsync(string modelName)
        {
            var result = await _generationService.GetGenerationsByModelNameAsync(modelName);

            if (result is null)
            {
                return NotFound("Generations not found.");
            }
            return Ok(result);
        }
    }
}
