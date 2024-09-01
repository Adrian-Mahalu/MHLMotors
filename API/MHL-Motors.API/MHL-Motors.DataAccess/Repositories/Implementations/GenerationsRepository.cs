using Dapper;
using MHL_Motors.DataAccess.DatabaseContext;
using MHL_Motors.DataAccess.Repositories.Interfaces;
using MHL_Motors.Models.CarDataModels;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace MHL_Motors.DataAccess.Repositories.Implementations
{
    public class GenerationsRepository : Repository<Generation>, IGenerationsRepository
    {
        private readonly IDbConnection _dapperConnection;
        private DataContext _context;

        public GenerationsRepository(DataContext context, IDbConnection dapperConnection) : base(context)
        {
            _dapperConnection = dapperConnection;
            _context = context;
        }

        public async Task<List<Generation>> GetAllGenerationsAsync()
        {
            var generations = await _dapperConnection.QueryAsync<Generation>("SELECT * FROM Generations");

            return generations.ToList();
        }

        public async Task<List<Generation>> GetGenerationsByModelNameAsync(string modelName)
        {
            return await _context.Cars.
                    Where(c => c.ModelName == modelName).
                    Select(car => new Generation
                    {
                        Id = car.Id,
                        BrandName = car.BrandName,
                        ModelName = car.ModelName,
                        BodyType = car.BodyType,
                        StartOfProduction = car.StartOfProduction,
                        EndOfProduction = car.EndOfProduction,
                        GenerationName = car.GenerationName,
                        EmissionStandard = car.EmissionStandard,
                        FuelType = car.FuelType,
                        LogoPath = car.GenerationLogoPath,
                        MinHorsePower = _context.Cars
                        .Where(c => c.GenerationName == car.GenerationName)
                        .Min(c => c.HorsePower),
                        MaxHorsePower = _context.Cars
                        .Where(c => c.GenerationName == car.GenerationName)
                        .Max(c => c.HorsePower)
                    }).
                    OrderByDescending(d => d.StartOfProduction).
                    ToListAsync();
        }

        public async Task<List<Generation>> GetGenerationsByNameAsync(string generationName)
        {
            var generations = await _dapperConnection.QueryAsync<Generation>("SELECT * FROM Generations WHERE GenerationName = @GenerationName",
                new { GenerationName = generationName });

            return generations.ToList();
        }
    }
}
