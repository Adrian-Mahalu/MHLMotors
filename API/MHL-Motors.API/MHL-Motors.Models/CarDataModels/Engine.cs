namespace MHL_Motors.Models.CarDataModels
{
    public class Engine
    {
        public Guid Id { get; set; }
        public int StartOfProduction { get; set; }
        public int EndOfProduction { get; set; }
        public string? EngineName { get; set; }
        public string? TypeOfGearbox { get; set; }
        public int EngineVolume { get; set; }
        public string Power { get; set; }
        public string ElectricMotorPower { get; set; }
        public int MaximumSpeed { get; set; }
        public string Fuel { get; set; }
        public string FuelType { get; set; }
        public double FuelEconomyCombined { get; set; }
    }
}
