using MHL_Motors.DataAccess.UnitOfWork;
using MHL_Motors.DataBuilders.DataBuilderHelpers;
using MHL_Motors.DataBuilders.DataBuilders;
using MHL_Motors.Models.CarDataModels;
using MHL_Motors.Services.ServiceHelpers;
using Microsoft.EntityFrameworkCore;

namespace MHL_Motors.Services.CarServices
{
    public class CarService : ICarService
    {
        private IUnitOfWork _unitOfWork;
        public CarService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddCarAdAsync(CarAd carAd)
        {
            var car = CarServiceHelperMethods.CreateCarFromCarAd(carAd);
            _unitOfWork.CarsRepository.Insert(car);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task AddCarsAsync()
        {
            string[] filePaths = CarDataBuilderHelperMethods.GetCarsFilePaths();

            foreach (var filePath in filePaths)
            {
                var car = CarDataBuilder.BuildCarFromCarContentHtmlFile(filePath);
                car.EngineCode = string.Empty;

                if (car != null)
                {
                    _unitOfWork.CarsRepository.Insert(car);
                }
            }

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<Car>> GetAllCarsAsync()
        {
            return await _unitOfWork.CarsRepository.GetAllCarsAsync();
        }

        public async Task<Car> GetCarByIdAsync(Guid id)
        {
            return await _unitOfWork.CarsRepository.GetCarByIdAsync(id);
        }

        public async Task<List<Car>> GetAllAsync()
        {
            return await _unitOfWork.CarsRepository.GetAllAsync();
        }

        public async Task<Car> GetByIdAsync(Guid id)
        {
            return await _unitOfWork.CarsRepository.GetByIdAsync(id);
        }

        public async Task UpdateCarAsync(Car car)
        {
            _unitOfWork.CarsRepository.Update(car);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteCarByIdAsync(Guid id)
        {
            Car car = await _unitOfWork.CarsRepository.GetByIdAsync(id);

            _unitOfWork.CarsRepository.Delete(car);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<Car>> GetCarsByBrandNameAsync(string brandName)
        {
            return await _unitOfWork.CarsRepository.GetQueriable().Where(x => x.BrandName == brandName).ToListAsync();
        }

        public async Task<List<Car>> GetCarsByGenerationNameAsync(string generationName)
        {
            return await _unitOfWork.CarsRepository.GetQueriable().Where(x => x.GenerationName == generationName).ToListAsync();
        }

        public async Task<List<Car>> GetCarsByModelNameAsync(string modelName)
        {
            return await _unitOfWork.CarsRepository.GetQueriable().Where(x => x.ModelName == modelName).ToListAsync();
        }
    }
}
