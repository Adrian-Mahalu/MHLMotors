using MHL_Motors.DataAccess.UnitOfWork;
using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.Services.CarServices
{
    public class ModelService : IModelService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ModelService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Model>> GetAllModelsAsync()
        {
            return await _unitOfWork.ModelsRepository.GetAllModelsAsync();
        }

        public async Task<List<Model>> GetModelsByBrandNameAsync(string brandName)
        {
            return await _unitOfWork.ModelsRepository.GetModelsByBrandNameAsync(brandName);
        }
    }
}
