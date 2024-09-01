using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.DataAccess.Repositories.Interfaces
{
    public interface IModelsRepository : IRepository<Model>
    {
        Task<List<Model>> GetAllModelsAsync();
        Task<List<Model>> GetModelsByBrandNameAsync(string brandName);
    }
}
