using MHL_Motors.DataAccess.DatabaseContext;
using MHL_Motors.DataAccess.Factories.CarFactories.TypeTwo;
using MHL_Motors.DataAccess.Repositories.Implementations;
using MHL_Motors.DataAccess.Repositories.Interfaces;
using MHL_Motors.DataAccess.UnitOfWork;
using MHL_Motors.Models.Interfaces;
using MHL_Motors.Services.CarServices;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Data;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});
builder.Services.AddAuthentication().AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidateAudience = false,
        ValidateIssuer = false,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
            builder.Configuration.GetSection("AppSettings:Token").Value!))
    };
});

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
builder.Services.AddTransient<IUser, UserRepository>();
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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
