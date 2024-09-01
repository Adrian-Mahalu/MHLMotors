using MHL_Motors.Models.CarModels.CarFactoryModels;

namespace MHL_Motors.DataAccess.Factories.CarFactories.TypeOne
{
    public abstract class DefaultCarFactory : IDefaultCarFactory
    {
        public abstract CarObject CreateCar();
    }
}
