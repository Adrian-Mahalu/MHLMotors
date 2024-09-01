using MHL_Motors.Models.CarModels.CarFactoryModels;

namespace MHL_Motors.DataAccess.Factories.CarFactories.TypeOne
{
    public class HydrogenCarFactory : DefaultCarFactory
    {
        public override CarObject CreateCar()
        {
            return new HydrogenCar();
        }
    }
}
