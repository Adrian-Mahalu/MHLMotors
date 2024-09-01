using Dapper;
using MHL_Motors.DataAccess.DatabaseContext;
using MHL_Motors.DataAccess.Repositories.Interfaces;
using MHL_Motors.Models.CarDataModels;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace MHL_Motors.DataAccess.Repositories.Implementations
{
    public class EnginesRepository : Repository<Engine>, IEnginesRepository
    {
        private readonly IDbConnection _dapperConnection;
        private DataContext _context;

        public EnginesRepository(DataContext context, IDbConnection dapperConnection) : base(context)
        {
            _dapperConnection = dapperConnection;
            _context = context;
        }

        public async Task<List<Engine>> GetEnginesByGenerationNameAsync(string generationName)
        {
            return await _context.Cars.
                  Where(c => c.GenerationName == generationName).
                  Select(car => new Engine
                  {
                      Id = car.Id,
                      EngineName = car.EngineName,
                      Power = car.Power,
                      EngineVolume = car.EngineVolume,
                      StartOfProduction = car.StartOfProduction,
                      EndOfProduction = car.EndOfProduction,
                      TypeOfGearbox = car.TypeOfGearbox,
                      MaximumSpeed = car.MaximumSpeed,
                      Fuel = car.Fuel,
                      FuelType = car.FuelType
                  }).
                  ToListAsync();
        }

        public async Task<Engine> GetEngineByIdAsync(Guid id)
        {
            return await _dapperConnection.QueryFirstAsync<Engine>("SELECT * FROM Engines WHERE Id = @Id",
                new { Id = id });
        }

        public async Task<List<Engine>> GetAllEnginesAsync()
        {
            var engines = await _dapperConnection.QueryAsync<Engine>("SELECT * FROM Engines");

            return engines.ToList();
        }
    }
}
