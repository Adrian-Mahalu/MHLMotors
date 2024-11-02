﻿// <auto-generated />
using System;
using MHL_Motors.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MHL_Motors.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241102062753_AddUsersTable")]
    partial class AddUsersTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MHL_Motors.Models.CarDataModels.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstLetter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCommonBrand")
                        .HasColumnType("bit");

                    b.Property<string>("LogoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("MHL_Motors.Models.CarDataModels.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("Acceleration0To100KmH")
                        .HasColumnType("float");

                    b.Property<double?>("Acceleration0To62MpH")
                        .HasColumnType("float");

                    b.Property<int>("AllElectricRange")
                        .HasColumnType("int");

                    b.Property<string>("AssistingSystems")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("AverageEnergyEconomy")
                        .HasColumnType("float");

                    b.Property<string>("BatteryTechnology")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BatteryVoltage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BodyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrandLogoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CO2Emissions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CompressionRatio")
                        .HasColumnType("float");

                    b.Property<double>("Coolant")
                        .HasColumnType("float");

                    b.Property<string>("CylinderBore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Doors")
                        .HasColumnType("int");

                    b.Property<double>("DragCoefficient")
                        .HasColumnType("float");

                    b.Property<string>("DriveTrainArchitecture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriveWheel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElectricMotorLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElectricMotorPower")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElectricMotorTorque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmissionStandard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EndOfProduction")
                        .HasColumnType("int");

                    b.Property<string>("EngineAspiration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineConfiguration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineLayout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineModelCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("EngineOilCapacity")
                        .HasColumnType("float");

                    b.Property<string>("EngineOilSpecification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineSystems")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EngineVolume")
                        .HasColumnType("int");

                    b.Property<string>("FrontBrakes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FrontOverhang")
                        .HasColumnType("int");

                    b.Property<string>("FrontSuspension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FrontTrack")
                        .HasColumnType("int");

                    b.Property<string>("Fuel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FuelEconomyCombined")
                        .HasColumnType("float");

                    b.Property<double>("FuelEconomyExtraUrban")
                        .HasColumnType("float");

                    b.Property<double>("FuelEconomyUrban")
                        .HasColumnType("float");

                    b.Property<string>("FuelInjectionSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FuelTankCapacity")
                        .HasColumnType("int");

                    b.Property<string>("FuelType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenerationLogoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenerationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrossBatteryCapacity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasDimensionsSpecs")
                        .HasColumnType("bit");

                    b.Property<bool>("HasDrivetrainBrakesAndSuspensionSpecs")
                        .HasColumnType("bit");

                    b.Property<bool>("HasElectricCarsAndHybridSpecs")
                        .HasColumnType("bit");

                    b.Property<bool>("HasEngineSpecs")
                        .HasColumnType("bit");

                    b.Property<bool>("HasGeneralInformationSpecs")
                        .HasColumnType("bit");

                    b.Property<bool>("HasPerformanceSpecs")
                        .HasColumnType("bit");

                    b.Property<bool>("HasSpaceVolumeAndWeightsSpescs")
                        .HasColumnType("bit");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("HorsePower")
                        .HasColumnType("int");

                    b.Property<bool>("IsCommonBrand")
                        .HasColumnType("bit");

                    b.Property<int>("KerbWeight")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int>("MaximumLoad")
                        .HasColumnType("int");

                    b.Property<int>("MaximumRoofLoad")
                        .HasColumnType("int");

                    b.Property<int>("MaximumSpeed")
                        .HasColumnType("int");

                    b.Property<int>("MaximumWeight")
                        .HasColumnType("int");

                    b.Property<string>("ModelLogoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfCylinders")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfValvesPerCylinder")
                        .HasColumnType("int");

                    b.Property<int>("PermittedTowBarDownload")
                        .HasColumnType("int");

                    b.Property<int>("PermittedTrailerLoadWithBrakes")
                        .HasColumnType("int");

                    b.Property<int>("PermittedTrailerLoadWithoutBreaks")
                        .HasColumnType("int");

                    b.Property<string>("PistonStroke")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Power")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowerPerLitre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowerSteering")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowertrainArchitecture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RearBrakes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RearOverhang")
                        .HasColumnType("int");

                    b.Property<string>("RearSuspension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RearTrack")
                        .HasColumnType("int");

                    b.Property<int>("RideHeight")
                        .HasColumnType("int");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.Property<int>("StartOfProduction")
                        .HasColumnType("int");

                    b.Property<string>("SteeringType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SystemPower")
                        .HasColumnType("int");

                    b.Property<int>("SystemTorque")
                        .HasColumnType("int");

                    b.Property<string>("TiresSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Torque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrunkSpace")
                        .HasColumnType("int");

                    b.Property<double>("TurningDiameter")
                        .HasColumnType("float");

                    b.Property<string>("TypeOfGearbox")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeightToPowerRatio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeightToTorqueRatio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WheelRimsSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wheelbase")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("MHL_Motors.Models.CarDataModels.Engine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ElectricMotorPower")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EndOfProduction")
                        .HasColumnType("int");

                    b.Property<string>("EngineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EngineVolume")
                        .HasColumnType("int");

                    b.Property<string>("Fuel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FuelEconomyCombined")
                        .HasColumnType("float");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaximumSpeed")
                        .HasColumnType("int");

                    b.Property<string>("Power")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartOfProduction")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfGearbox")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("MHL_Motors.Models.CarDataModels.Generation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BodyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmissionStandard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EndOfProduction")
                        .HasColumnType("int");

                    b.Property<string>("FuelType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenerationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxHorsePower")
                        .HasColumnType("int");

                    b.Property<int>("MinHorsePower")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartOfProduction")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Generations");
                });

            modelBuilder.Entity("MHL_Motors.Models.CarDataModels.Model", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstCharacter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("MHL_Motors.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
