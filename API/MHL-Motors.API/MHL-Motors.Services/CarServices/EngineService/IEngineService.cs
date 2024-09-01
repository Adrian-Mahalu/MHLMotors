using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.Services.CarServices
{
    public interface IEngineService
    {
        Task<List<Engine>> GetAllEnginesAsync();
        Task<Engine> GetEngineByIdAsync(Guid id);
        Task<List<Engine>> GetEnginesByGenerationNameAsync(string generationName);
    }
}
