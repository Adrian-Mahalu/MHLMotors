using MHL_Motors.DataAccess.DatabaseContext;
using MHL_Motors.DataAccess.Factories.CarFactories.TypeTwo;
using MHL_Motors.DataAccess.Repositories.Implementations;
using MHL_Motors.DataAccess.Repositories.Interfaces;
using MHL_Motors.DataAccess.UnitOfWork;
using MHL_Motors.Services.CarServices;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// SQL Connections
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MHLMotorsDBConnection"));
}, ServiceLifetime.Transient);

builder.Services.AddScoped<IDbConnection>(connection =>
new SqlConnection(builder.Configuration.GetConnectionString("MHLMotorsDBConnection")));
// ----------------------------------------------------------------------------------------------------------------------------------


// DI
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
//builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
// REPOSITORIES
builder.Services.AddTransient<ICarFactory, CarFactory>();
builder.Services.AddTransient<ICarsRepository, CarsRepository>();
builder.Services.AddTransient<IBrandsRepository, BrandsRepository>();
builder.Services.AddTransient<IGenerationsRepository, GenerationsRepository>();
builder.Services.AddTransient<IModelsRepository, ModelsRepository>();
builder.Services.AddTransient<IEnginesRepository, EnginesRepository>();
// SERVICES
builder.Services.AddTransient<ICarService, CarService>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IBrandService, BrandService>();
builder.Services.AddTransient<IEngineService, EngineService>();
builder.Services.AddTransient<IGenerationService, GenerationService>();
builder.Services.AddTransient<IModelService, ModelService>();

builder.Services.AddCors(options => options.AddPolicy(name: "MHLMotorsOrigins", policy =>
{
    //It is :4200, because we see it in .vscode-- > launch.json
    policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
}));

// ----------------------------------------------------------------------------------------------------------------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseCors("MHLMotorsOrigins");

app.UseHttpsRedirection();

// For simplicity purposes
app.UseCors(options =>
{
    options.AllowAnyHeader();
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
