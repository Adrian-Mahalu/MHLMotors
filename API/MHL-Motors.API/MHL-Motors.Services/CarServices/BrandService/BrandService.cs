using MHL_Motors.DataAccess.UnitOfWork;
using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.Services.CarServices
{
    public class BrandService : IBrandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BrandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Brand>> GetAllBrandsAsync()
        {
            return await _unitOfWork.BrandsRepository.GetAllBrandsAsync();
        }

        public async Task<List<Brand>> GetCommonBrandsAsync()
        {
            return await _unitOfWork.BrandsRepository.GetCommonBrandsAsync();
        }
    }
}
