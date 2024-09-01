using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MHL_Motors.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCoreObjectsForCarData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BrandName",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstCharacter",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LogoPath",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModelName",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BodyType",
                table: "Generations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrandName",
                table: "Generations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmissionStandard",
                table: "Generations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EndOfProduction",
                table: "Generations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FuelType",
                table: "Generations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GenerationName",
                table: "Generations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoPath",
                table: "Generations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxHorsePower",
                table: "Generations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinHorsePower",
                table: "Generations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ModelName",
                table: "Generations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StartOfProduction",
                table: "Generations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ElectricMotorPower",
                table: "Engines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EndOfProduction",
                table: "Engines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EngineName",
                table: "Engines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EngineVolume",
                table: "Engines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Fuel",
                table: "Engines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "FuelEconomyCombined",
                table: "Engines",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "FuelType",
                table: "Engines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MaximumSpeed",
                table: "Engines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Power",
                table: "Engines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StartOfProduction",
                table: "Engines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfGearbox",
                table: "Engines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Acceleration0To100KmH",
                table: "Cars",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Acceleration0To62MpH",
                table: "Cars",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AllElectricRange",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AssistingSystems",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AverageEnergyEconomy",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "BatteryTechnology",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BatteryVoltage",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BodyType",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrandLogoPath",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CO2Emissions",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CompressionRatio",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Coolant",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "CylinderBore",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Doors",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "DragCoefficient",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "DriveTrainArchitecture",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DriveWheel",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElectricMotorLocation",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElectricMotorPower",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ElectricMotorTorque",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmissionStandard",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EndOfProduction",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EngineAspiration",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EngineConfiguration",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EngineLayout",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EngineModelCode",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EngineName",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "EngineOilCapacity",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "EngineOilSpecification",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EngineSystems",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EngineVolume",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FrontBrakes",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FrontOverhang",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FrontSuspension",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FrontTrack",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Fuel",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FuelEconomyCombined",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FuelEconomyExtraUrban",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FuelEconomyUrban",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "FuelInjectionSystem",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FuelTankCapacity",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FuelType",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GenerationLogoPath",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GrossBatteryCapacity",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasDimensionsSpecs",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasDrivetrainBrakesAndSuspensionSpecs",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasElectricCarsAndHybridSpecs",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasEngineSpecs",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasGeneralInformationSpecs",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasPerformanceSpecs",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasSpaceVolumeAndWeightsSpescs",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HorsePower",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsCommonBrand",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "KerbWeight",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaximumLoad",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaximumRoofLoad",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaximumSpeed",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaximumWeight",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ModelLogoPath",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfCylinders",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfValvesPerCylinder",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PermittedTowBarDownload",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PermittedTrailerLoadWithBrakes",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PermittedTrailerLoadWithoutBreaks",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PistonStroke",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Power",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PowerPerLitre",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PowerSteering",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PowertrainArchitecture",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RearBrakes",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RearOverhang",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RearSuspension",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RearTrack",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RideHeight",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Seats",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartOfProduction",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SteeringType",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SystemPower",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SystemTorque",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TiresSize",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Torque",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrunkSpace",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TurningDiameter",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfGearbox",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeightToPowerRatio",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeightToTorqueRatio",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WheelRimsSize",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Wheelbase",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BrandName",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstLetter",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCommonBrand",
                table: "Brands",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LogoPath",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrandName",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "FirstCharacter",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "LogoPath",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "ModelName",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "BodyType",
                table: "Generations");

            migrationBuilder.DropColumn(
                name: "BrandName",
                table: "Generations");

            migrationBuilder.DropColumn(
                name: "EmissionStandard",
                table: "Generations");

            migrationBuilder.DropColumn(
                name: "EndOfProduction",
                table: "Generations");

            migrationBuilder.DropColumn(
                name: "FuelType",
                table: "Generations");

            migrationBuilder.DropColumn(
                name: "GenerationName",
                table: "Generations");

            migrationBuilder.DropColumn(
                name: "LogoPath",
                table: "Generations");

            migrationBuilder.DropColumn(
                name: "MaxHorsePower",
                table: "Generations");

            migrationBuilder.DropColumn(
                name: "MinHorsePower",
                table: "Generations");

            migrationBuilder.DropColumn(
                name: "ModelName",
                table: "Generations");

            migrationBuilder.DropColumn(
                name: "StartOfProduction",
                table: "Generations");

            migrationBuilder.DropColumn(
                name: "ElectricMotorPower",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "EndOfProduction",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "EngineName",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "EngineVolume",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "Fuel",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "FuelEconomyCombined",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "FuelType",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "MaximumSpeed",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "Power",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "StartOfProduction",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "TypeOfGearbox",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "Acceleration0To100KmH",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Acceleration0To62MpH",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "AllElectricRange",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "AssistingSystems",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "AverageEnergyEconomy",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "BatteryTechnology",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "BatteryVoltage",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "BodyType",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "BrandLogoPath",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CO2Emissions",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CompressionRatio",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Coolant",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CylinderBore",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Doors",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "DragCoefficient",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "DriveTrainArchitecture",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "DriveWheel",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ElectricMotorLocation",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ElectricMotorPower",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ElectricMotorTorque",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EmissionStandard",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EndOfProduction",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EngineAspiration",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EngineConfiguration",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EngineLayout",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EngineModelCode",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EngineName",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EngineOilCapacity",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EngineOilSpecification",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EngineSystems",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EngineVolume",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FrontBrakes",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FrontOverhang",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FrontSuspension",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FrontTrack",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Fuel",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FuelEconomyCombined",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FuelEconomyExtraUrban",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FuelEconomyUrban",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FuelInjectionSystem",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FuelTankCapacity",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FuelType",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "GenerationLogoPath",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "GrossBatteryCapacity",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasDimensionsSpecs",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasDrivetrainBrakesAndSuspensionSpecs",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasElectricCarsAndHybridSpecs",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasEngineSpecs",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasGeneralInformationSpecs",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasPerformanceSpecs",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasSpaceVolumeAndWeightsSpescs",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HorsePower",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "IsCommonBrand",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "KerbWeight",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "MaximumLoad",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "MaximumRoofLoad",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "MaximumSpeed",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "MaximumWeight",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ModelLogoPath",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "NumberOfCylinders",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "NumberOfValvesPerCylinder",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PermittedTowBarDownload",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PermittedTrailerLoadWithBrakes",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PermittedTrailerLoadWithoutBreaks",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PistonStroke",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Power",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PowerPerLitre",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PowerSteering",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PowertrainArchitecture",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "RearBrakes",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "RearOverhang",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "RearSuspension",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "RearTrack",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "RideHeight",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Seats",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "StartOfProduction",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SteeringType",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SystemPower",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SystemTorque",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "TiresSize",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Torque",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "TrunkSpace",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "TurningDiameter",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "TypeOfGearbox",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "WeightToPowerRatio",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "WeightToTorqueRatio",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "WheelRimsSize",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Wheelbase",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "BrandName",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "FirstLetter",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "IsCommonBrand",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "LogoPath",
                table: "Brands");
        }
    }
}
