using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.DataAccess.Repositories.Interfaces
{
    public interface IEnginesRepository : IRepository<Engine>
    {
        Task<List<Engine>> GetAllEnginesAsync();
        Task<List<Engine>> GetEnginesByGenerationNameAsync(string generationName);
        Task<Engine> GetEngineByIdAsync(Guid id);
    }
}
