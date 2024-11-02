using MHL_Motors.Models.CarDataModels;
using MHL_Motors.Services.CarServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MHL_Motors.API.Controllers.CarManagementControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("GetAllBrandsAsync"), Authorize(Roles = "Admin,userRole")]
        public async Task<ActionResult<List<Brand>>> GetAllBrandsAsync()
        {
            var result = await _brandService.GetAllBrandsAsync();
            if (result is null)
            {
                return NotFound("Brands not found.");
            }
            return Ok(result);
        }

        [HttpGet("GetCommonBrandsAsync")]
        public async Task<ActionResult<List<Brand>>> GetCommonBrandsAsync()
        {
            var result = await _brandService.GetCommonBrandsAsync();
            if (result is null)
            {
                return NotFound("Common brands not found.");
            }
            return Ok(result);
        }
    }
}
