using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.DataAccess.Repositories.Interfaces
{
    public interface IBrandsRepository : IRepository<Brand>
    {
        Task<List<Brand>> GetAllBrandsAsync();
        Task<List<Brand>> GetCommonBrandsAsync();
    }
}
