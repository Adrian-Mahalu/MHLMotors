using MHL_Motors.Models.CarDataModels;
using MHL_Motors.Services.CarServices;
using Microsoft.AspNetCore.Mvc;

namespace MHL_Motors.API.Controllers.CarManagementControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : Controller
    {
        private readonly IModelService _modelService;

        public ModelController(IModelService modelService)
        {
            _modelService = modelService;
        }

        [HttpGet("GetAllModelsAsync")]
        public async Task<ActionResult<List<Model>>> GetAllModelsAsync()
        {
            var result = await _modelService.GetAllModelsAsync();
            if (result is null)
            {
                return NotFound("Models not found.");
            }
            return Ok(result);
        }

        [HttpGet("GetModelsByBrandNameAsync/{brandName}")]
        public async Task<ActionResult<List<Model>>> GetModelsByBrandNameAsync(string brandName)
        {
            var result = await _modelService.GetModelsByBrandNameAsync(brandName);
            if (result is null)
            {
                return NotFound("Models not found.");
            }
            return Ok(result);
        }
    }
}
