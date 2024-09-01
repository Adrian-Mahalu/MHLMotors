using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.Services.CarServices
{
    public interface IBrandService
    {
        Task<List<Brand>> GetAllBrandsAsync();
        Task<List<Brand>> GetCommonBrandsAsync();
    }
}
