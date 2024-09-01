using MHL_Motors.Models.CarModels.CarFactoryModels;

namespace MHL_Motors.DataAccess.Factories.CarFactories.TypeTwo
{
    public class CarFactory : ICarFactory
    {
        public CarObject CreateCar(Type carType)
        {
                if (carType == typeof(PetrolCar))
                {
                    return new PetrolCar();
                }
                else if (carType == typeof(ElectricCar))
                {
                    return new ElectricCar();
                }
                else if (carType == typeof(HydrogenCar))
                {
                    return new HydrogenCar();
                }
                else if (carType == typeof(HybridCar))
                {
                    return new HybridCar();
                }

            throw new ArgumentException("Invalid car type.");
        }
    }
}
