using System.ComponentModel.DataAnnotations.Schema;

namespace MHL_Motors.Models.CarModels.CarFactoryModels
{
    [NotMapped]
    public abstract class CarObject
    {
        // MUST INCLUDE COMMON PROPERTIES FOR CARS. THE OTHER CLASSES MUST INCLUDE SPECIFIC PROPERTIES
        public int Id { get; set; }
        public string? GenerationLogoPath { get; set; }
        public string? BrandLogoPath { get; set; }
        public string? ModelLogoPath { get; set; }
        public string? BrandName { get; set; }
        public bool IsCommonBrand { get; set; }
        public string? ModelName { get; set; }
        public string? GenerationName { get; set; }
        public string? EngineName { get; set; }
        public string? EngineModelCode { get; set; }
        public string? Power { get; set; }
        public int HorsePower { get; set; }
        public string? PowerPerLitre { get; set; }
        public string? Torque { get; set; }
        public string? EngineLayout { get; set; }
        public int EngineVolume { get; set; }
        public int NumberOfCylinders { get; set; }
        public string? EngineConfiguration { get; set; }
        public string? CylinderBore { get; set; }
        public string? PistonStroke { get; set; }
        public double CompressionRatio { get; set; }
        public int NumberOfValvesPerCylinder { get; set; }
        public string? FuelInjectionSystem { get; set; }
        public string? EngineAspiration { get; set; }
        public double EngineOilCapacity { get; set; }
        public double Coolant { get; set; }
        public string? EngineSystems { get; set; }
        public string? EngineOilSpecification { get; set; }

        #region General Information Specs
        public int StartOfProduction { get; set; }
        public int EndOfProduction { get; set; }
        public string? PowertrainArchitecture { get; set; }
        public string? BodyType { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        #endregion

        #region Performance Specs
        public double FuelEconomyUrban { get; set; }
        public double FuelEconomyExtraUrban { get; set; }
        public double FuelEconomyCombined { get; set; }
        public string? Fuel { get; set; }
        public string? CO2Emissions { get; set; }
        public double? Acceleration0To100KmH { get; set; }
        public double? Acceleration0To62MpH { get; set; }
        public string? FuelType { get; set; }
        public int MaximumSpeed { get; set; }
        public string? EmissionStandard { get; set; }
        public string? WeightToPowerRatio { get; set; }
        public string? WeightToTorqueRatio { get; set; }
        #endregion

        #region Space, Volume, Weights Specs
        public int KerbWeight { get; set; }
        public int MaximumWeight { get; set; }
        public int MaximumLoad { get; set; }
        public int TrunkSpace { get; set; }
        public int FuelTankCapacity { get; set; }
        public int MaximumRoofLoad { get; set; }
        public int PermittedTrailerLoadWithBrakes { get; set; }
        public int PermittedTrailerLoadWithoutBreaks { get; set; }
        public int PermittedTowBarDownload { get; set; }
        #endregion

        #region Dimensions
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Wheelbase { get; set; }
        public int FrontTrack { get; set; }
        public int RearTrack { get; set; }
        public int FrontOverhang { get; set; }
        public int RearOverhang { get; set; }
        public int RideHeight { get; set; }
        public double DragCoefficient { get; set; }
        public double TurningDiameter { get; set; }
        #endregion

        #region Drivetrain, Brakes, Suspension Specs
        public string? DriveTrainArchitecture { get; set; }
        public string? DriveWheel { get; set; }
        public string? TypeOfGearbox { get; set; }
        public string? FrontSuspension { get; set; }
        public string? RearSuspension { get; set; }
        public string? FrontBrakes { get; set; }
        public string? RearBrakes { get; set; }
        public string? AssistingSystems { get; set; }
        public string? SteeringType { get; set; }
        public string? TiresSize { get; set; }
        public string? WheelRimsSize { get; set; }
        public string? PowerSteering { get; set; }
        #endregion

        #region Electric cars and hybrid specs
        public string? GrossBatteryCapacity { get; set; }
        public string? BatteryVoltage { get; set; }
        public string? BatteryTechnology { get; set; }
        public int AllElectricRange { get; set; }
        public double AverageEnergyEconomy { get; set; }
        public string ElectricMotorPower { get; set; }
        public string ElectricMotorTorque { get; set; }
        public string? ElectricMotorLocation { get; set; }
        public int SystemPower { get; set; }
        public int SystemTorque { get; set; }
        #endregion

        #region Validation
        public bool HasGeneralInformationSpecs { get; set; }
        public bool HasPerformanceSpecs { get; set; }
        public bool HasEngineSpecs { get; set; }
        public bool HasElectricCarsAndHybridSpecs { get; set; }
        public bool HasSpaceVolumeAndWeightsSpescs { get; set; }
        public bool HasDimensionsSpecs { get; set; }
        public bool HasDrivetrainBrakesAndSuspensionSpecs { get; set; }
        #endregion
    }
}
