using MHL_Motors.DataAccess.UnitOfWork;
using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.Services.CarServices
{
    public class EngineService : IEngineService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EngineService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Engine>> GetAllEnginesAsync()
        {
            return await _unitOfWork.EnginesRepository.GetAllEnginesAsync();
        }

        public async Task<List<Engine>> GetEnginesByGenerationNameAsync(string generationName)
        {
            return await _unitOfWork.EnginesRepository.GetEnginesByGenerationNameAsync(generationName);
        }

        public async Task<Engine> GetEngineByIdAsync(Guid id)
        {
            return await _unitOfWork.EnginesRepository.GetEngineByIdAsync(id);
        }
    }
}
