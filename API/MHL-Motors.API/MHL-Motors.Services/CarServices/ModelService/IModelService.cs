using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.Services.CarServices
{
    public interface IModelService
    {
        Task<List<Model>> GetAllModelsAsync();
        Task<List<Model>> GetModelsByBrandNameAsync(string brandName);
    }
}
