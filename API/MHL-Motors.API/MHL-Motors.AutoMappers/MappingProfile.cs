using AutoMapper;
using MHL_Motors.Core.Constants;
using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.AutoMappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dictionary<string, string>, Car>()
                    .ForMember(car => car.BrandName, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.Brand) ? src[CarDataBuilderConstants.Brand] : null))
                    .ForMember(car => car.ModelName, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.Model) ? src[CarDataBuilderConstants.Model] : null))
                    .ForMember(car => car.GenerationName, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.Generation) ? src[CarDataBuilderConstants.Generation] : null))
                    .ForMember(car => car.EngineName, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.EngineName) ? src[CarDataBuilderConstants.EngineName] : string.Empty))
                    .ForMember(car => car.EngineModelCode, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.EngineModelCode) ? src[CarDataBuilderConstants.EngineModelCode] : null))
                    .ForMember(car => car.Power, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.Power) ? src[CarDataBuilderConstants.Power] : null))
                    .ForMember(car => car.Torque, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.Torque) ? src[CarDataBuilderConstants.Torque] : null))
                    .ForMember(car => car.EngineLayout, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.EngineLayout) ? src[CarDataBuilderConstants.EngineLayout] : null))
                    .ForMember(car => car.EngineVolume, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.EngineVolume) ? Convert.ToInt32(src[CarDataBuilderConstants.EngineVolume]) : 0))
                    .ForMember(car => car.NumberOfCylinders, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.NumberOfCylinders) ? Convert.ToInt32(src[CarDataBuilderConstants.NumberOfCylinders]) : 0))
                    .ForMember(car => car.EngineConfiguration, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.EngineConfiguration) ? src[CarDataBuilderConstants.EngineConfiguration] : null))
                    .ForMember(car => car.CylinderBore, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.CylinderBore) ? src[CarDataBuilderConstants.CylinderBore] : null))
                    .ForMember(car => car.PistonStroke, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.PistonStroke) ? src[CarDataBuilderConstants.PistonStroke] : null))
                    .ForMember(car => car.CompressionRatio, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.CompressionRatio) ? Convert.ToDouble(src[CarDataBuilderConstants.CompressionRatio]) : 0))
                    .ForMember(car => car.NumberOfValvesPerCylinder, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.NumberOfValvesPerCylinder) ? Convert.ToInt32(src[CarDataBuilderConstants.NumberOfValvesPerCylinder]) : 0))
                    .ForMember(car => car.FuelInjectionSystem, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.FuelInjectionSystem) ? src[CarDataBuilderConstants.FuelInjectionSystem] : null))
                    .ForMember(car => car.EngineAspiration, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.EngineAspiration) ? src[CarDataBuilderConstants.EngineAspiration] : null))
                    .ForMember(car => car.EngineOilCapacity, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.EngineOilCapacity) ? Convert.ToDouble(src[CarDataBuilderConstants.EngineOilCapacity]) : 0))
                    .ForMember(car => car.Coolant, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.Coolant) ? Convert.ToDouble(src[CarDataBuilderConstants.Coolant]) : 0))
                    .ForMember(car => car.EngineSystems, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.EngineSystems) ? src[CarDataBuilderConstants.EngineSystems] : null))
                    .ForMember(car => car.StartOfProduction, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.StartOfProduction) ? Convert.ToInt32(src[CarDataBuilderConstants.StartOfProduction]) : 0))
                    .ForMember(car => car.EndOfProduction, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.EndOfProduction) ? Convert.ToInt32(src[CarDataBuilderConstants.EndOfProduction]) : 0))
                    .ForMember(car => car.Seats, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.Seats) ? Convert.ToInt32(src[CarDataBuilderConstants.Seats]) : 0))
                    .ForMember(car => car.Doors, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.Doors) ? Convert.ToInt32(src[CarDataBuilderConstants.Doors]) : 0))
                    .ForMember(car => car.PowertrainArchitecture, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.PowertrainArchitecture) ? src[CarDataBuilderConstants.PowertrainArchitecture] : null))
                    .ForMember(car => car.BodyType, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.BodyType) ? src[CarDataBuilderConstants.BodyType] : null))
                    .ForMember(car => car.FuelEconomyUrban, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.FuelEconomyUrban) ? Convert.ToDouble(src[CarDataBuilderConstants.FuelEconomyUrban]) : 0))
                    .ForMember(car => car.FuelEconomyExtraUrban, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.FuelEconomyExtraUrban) ? Convert.ToDouble(src[CarDataBuilderConstants.FuelEconomyExtraUrban]) : 0))
                    .ForMember(car => car.FuelEconomyCombined, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.FuelEconomyCombined) ? Convert.ToDouble(src[CarDataBuilderConstants.FuelEconomyCombined]) : 0))
                    .ForMember(car => car.CO2Emissions, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.CO2Emissions) ? src[CarDataBuilderConstants.CO2Emissions] : null))
                    .ForMember(car => car.Acceleration0To100KmH, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.Acceleration0To100KmH) ? Convert.ToDouble(src[CarDataBuilderConstants.Acceleration0To100KmH]) : 0))
                    .ForMember(car => car.Acceleration0To62MpH, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.Acceleration0To62MpH) ? Convert.ToDouble(src[CarDataBuilderConstants.Acceleration0To62MpH]) : 0))
                    .ForMember(car => car.FuelType, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.FuelType) ? src[CarDataBuilderConstants.FuelType] : null))
                    .ForMember(car => car.MaximumSpeed, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.MaximumSpeed) ? Convert.ToInt32(src[CarDataBuilderConstants.MaximumSpeed]) : 0))
                    .ForMember(car => car.EmissionStandard, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.EmissionStandard) ? src[CarDataBuilderConstants.EmissionStandard] : null))
                    .ForMember(car => car.WeightToPowerRatio, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.WeightToPowerRatio) ? src[CarDataBuilderConstants.WeightToPowerRatio] : null))
                    .ForMember(car => car.WeightToTorqueRatio, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.WeightToTorqueRatio) ? src[CarDataBuilderConstants.WeightToTorqueRatio] : null))
                    .ForMember(car => car.KerbWeight, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.KerbWeight) ? Convert.ToInt32(src[CarDataBuilderConstants.KerbWeight]) : 0))
                    .ForMember(car => car.MaximumWeight, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.MaximumWeight) ? Convert.ToInt32(src[CarDataBuilderConstants.MaximumWeight]) : 0))
                    .ForMember(car => car.MaximumLoad, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.MaximumLoad) ? Convert.ToInt32(src[CarDataBuilderConstants.MaximumLoad]) : 0))
                    .ForMember(car => car.TrunkSpace, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.TrunkSpace) ? Convert.ToInt32(src[CarDataBuilderConstants.TrunkSpace]) : 0))
                    .ForMember(car => car.FuelTankCapacity, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.FuelTankCapacity) ? Convert.ToInt32(src[CarDataBuilderConstants.FuelTankCapacity]) : 0))
                    .ForMember(car => car.MaximumRoofLoad, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.MaximumRoofLoad) ? Convert.ToInt32(src[CarDataBuilderConstants.MaximumRoofLoad]) : 0))
                    .ForMember(car => car.PermittedTrailerLoadWithBrakes, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.PermittedTrailerLoadWithBrakes) ? Convert.ToInt32(src[CarDataBuilderConstants.PermittedTrailerLoadWithBrakes]) : 0))
                    .ForMember(car => car.PermittedTrailerLoadWithoutBreaks, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.PermittedTrailerLoadWithoutBreaks) ? Convert.ToInt32(src[CarDataBuilderConstants.PermittedTrailerLoadWithoutBreaks]) : 0))
                    .ForMember(car => car.PermittedTowBarDownload, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.PermittedTowBarDownload) ? Convert.ToInt32(src[CarDataBuilderConstants.PermittedTowBarDownload]) : 0))
                    .ForMember(car => car.Length, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.Length) ? Convert.ToInt32(src[CarDataBuilderConstants.Length]) : 0))
                    .ForMember(car => car.Width, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.Width) ? Convert.ToInt32(src[CarDataBuilderConstants.Width]) : 0))
                    .ForMember(car => car.Height, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.Height) ? Convert.ToInt32(src[CarDataBuilderConstants.Height]) : 0))
                    .ForMember(car => car.Wheelbase, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.Wheelbase) ? Convert.ToInt32(src[CarDataBuilderConstants.Wheelbase]) : 0))
                    .ForMember(car => car.FrontTrack, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.FrontTrack) ? Convert.ToInt32(src[CarDataBuilderConstants.FrontTrack]) : 0))
                    .ForMember(car => car.RearTrack, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.RearTrack) ? Convert.ToInt32(src[CarDataBuilderConstants.RearTrack]) : 0))
                    .ForMember(car => car.FrontOverhang, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.FrontOverhang) ? Convert.ToInt32(src[CarDataBuilderConstants.FrontOverhang]) : 0))
                    .ForMember(car => car.RearOverhang, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.RearOverhang) ? Convert.ToInt32(src[CarDataBuilderConstants.RearOverhang]) : 0))
                    .ForMember(car => car.RideHeight, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.RideHeight) ? Convert.ToInt32(src[CarDataBuilderConstants.RideHeight]) : 0))
                    .ForMember(car => car.DragCoefficient, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.DragCoefficient) ? Convert.ToDouble(src[CarDataBuilderConstants.DragCoefficient]) : 0))
                    .ForMember(car => car.TurningDiameter, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.TurningDiameter) ? Convert.ToDouble(src[CarDataBuilderConstants.TurningDiameter]) : 0))
                    .ForMember(car => car.DriveTrainArchitecture, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.DriveTrainArchitecture) ? src[CarDataBuilderConstants.DriveTrainArchitecture] : null))
                    .ForMember(car => car.DriveWheel, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.DriveWheel) ? src[CarDataBuilderConstants.DriveWheel] : null))
                    .ForMember(car => car.TypeOfGearbox, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.TypeOfGearbox) ? src[CarDataBuilderConstants.TypeOfGearbox] : null))
                    .ForMember(car => car.FrontSuspension, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.FrontSuspension) ? src[CarDataBuilderConstants.FrontSuspension] : null))
                    .ForMember(car => car.RearSuspension, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.RearSuspension) ? src[CarDataBuilderConstants.RearSuspension] : null))
                    .ForMember(car => car.FrontBrakes, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.FrontBrakes) ? src[CarDataBuilderConstants.FrontBrakes] : null))
                    .ForMember(car => car.RearBrakes, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.RearBrakes) ? src[CarDataBuilderConstants.RearBrakes] : null))
                    .ForMember(car => car.AssistingSystems, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.AssistingSystems) ? src[CarDataBuilderConstants.AssistingSystems] : null))
                    .ForMember(car => car.SteeringType, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.SteeringType) ? src[CarDataBuilderConstants.SteeringType] : null))
                    .ForMember(car => car.TiresSize, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.TiresSize) ? src[CarDataBuilderConstants.TiresSize] : null))
                    .ForMember(car => car.WheelRimsSize, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.WheelRimsSize) ? src[CarDataBuilderConstants.WheelRimsSize] : null))
                    .ForMember(car => car.PowerSteering, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.PowerSteering) ? src[CarDataBuilderConstants.PowerSteering] : null))
                    .ForMember(car => car.GrossBatteryCapacity, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.GrossBatteryCapacity) ? src[CarDataBuilderConstants.GrossBatteryCapacity] : null))
                    .ForMember(car => car.BatteryVoltage, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.BatteryVoltage) ? src[CarDataBuilderConstants.BatteryVoltage] : null))
                    .ForMember(car => car.BatteryTechnology, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.BatteryTechnology) ? src[CarDataBuilderConstants.BatteryTechnology] : null))
                    .ForMember(car => car.AllElectricRange, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.AllElectricRange) ? Convert.ToInt32(src[CarDataBuilderConstants.AllElectricRange]) : 0))
                    .ForMember(car => car.AverageEnergyEconomy, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.AverageEnergyEconomy) ? Convert.ToDouble(src[CarDataBuilderConstants.AverageEnergyEconomy]) : 0))
                    .ForMember(car => car.ElectricMotorPower, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.ElectricMotorPower) ? Convert.ToInt32(src[CarDataBuilderConstants.ElectricMotorPower]) : 0))
                    .ForMember(car => car.ElectricMotorTorque, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.ElectricMotorTorque) ? Convert.ToInt32(src[CarDataBuilderConstants.ElectricMotorTorque]) : 0))
                    .ForMember(car => car.ElectricMotorLocation, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.ElectricMotorLocation) ? src[CarDataBuilderConstants.ElectricMotorLocation] : null))
                    .ForMember(car => car.SystemPower, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.SystemPower) ? Convert.ToInt32(src[CarDataBuilderConstants.SystemPower]) : 0))
                    .ForMember(car => car.SystemTorque, opt => opt.MapFrom(src =>
                    src.ContainsKey(CarDataBuilderConstants.SystemTorque) ? Convert.ToInt32(src[CarDataBuilderConstants.SystemTorque]) : 0));
            //.ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}
