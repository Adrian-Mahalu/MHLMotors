using MHL_Motors.Models.CarModels.CarFactoryModels;

namespace MHL_Motors.DataAccess.Factories.CarFactories.TypeTwo
{
    public interface ICarFactory
    {
        CarObject CreateCar(Type carType);
    }
}
