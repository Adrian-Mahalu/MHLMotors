using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.DataAccess.Repositories.Interfaces
{
        public interface ICarsRepository : IRepository<Car>
        {
            Task<List<Car>> GetAllCarsAsync();
            Task<Car> GetCarByIdAsync(Guid id);
        }
}
