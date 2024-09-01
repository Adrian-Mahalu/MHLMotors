using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.Services.CarServices
{
    public interface IGenerationService
    {
        Task<List<Generation>> GetAllGenerationsAsync();
        Task<List<Generation>> GetGenerationsByNameAsync(string generationName);
        Task<List<Generation>> GetGenerationsByModelNameAsync(string modelName);
    }
}
