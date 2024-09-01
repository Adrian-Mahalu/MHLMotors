using MHL_Motors.DataAccess.UnitOfWork;
using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.Services.CarServices
{
    public class GenerationService : IGenerationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenerationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Generation>> GetAllGenerationsAsync()
        {
            return await _unitOfWork.GenerationsRepository.GetAllGenerationsAsync();
        }

        public async Task<List<Generation>> GetGenerationsByModelNameAsync(string modelName)
        {
            return await _unitOfWork.GenerationsRepository.GetGenerationsByModelNameAsync(modelName);
        }

        public async Task<List<Generation>> GetGenerationsByNameAsync(string generationName)
        {
            return await _unitOfWork.GenerationsRepository.GetGenerationsByNameAsync(generationName);
        }
    }
}
