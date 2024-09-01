using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.Services.ServiceHelpers
{
    public static class CarServiceHelperMethods
    {
        public static Car CreateCarFromCarAd(CarAd carAd)
        {
            Car car = new Car();

            car.Id = Guid.NewGuid();
            car.BrandName = carAd.BrandName;
            car.ModelName = carAd.ModelName;
            car.GenerationName = carAd.GenerationName;
            car.EngineName = carAd.EngineName;
            car.Power = carAd.Power;

            car.ElectricMotorPower = string.Empty;
            car.ElectricMotorTorque = string.Empty;
            car.EngineCode = string.Empty;

            return car;
        }
    }
}
