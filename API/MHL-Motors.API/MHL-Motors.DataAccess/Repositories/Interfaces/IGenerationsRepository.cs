using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.DataAccess.Repositories.Interfaces
{
    public interface IGenerationsRepository : IRepository<Generation>
    {
        Task<List<Generation>> GetAllGenerationsAsync();
        Task<List<Generation>> GetGenerationsByNameAsync(string generationName);
        Task<List<Generation>> GetGenerationsByModelNameAsync(string modelName);
    }
}
