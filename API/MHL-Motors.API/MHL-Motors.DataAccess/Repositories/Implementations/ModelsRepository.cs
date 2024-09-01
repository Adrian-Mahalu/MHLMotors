using Dapper;
using MHL_Motors.DataAccess.DatabaseContext;
using MHL_Motors.DataAccess.Repositories.Interfaces;
using MHL_Motors.Models.CarDataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHL_Motors.DataAccess.Repositories.Implementations
{
    public class ModelsRepository : Repository<Model>, IModelsRepository
    {
        private readonly IDbConnection _dapperConnection;
        private DataContext _context;

        public ModelsRepository(DataContext context, IDbConnection dapperConnection) : base(context)
        {
            _dapperConnection = dapperConnection;
            _context = context;
        }

        public async Task<List<Model>> GetAllModelsAsync()
        {
            var models = await _dapperConnection.QueryAsync<Model>("SELECT * FROM Models");

            return models.ToList();
        }

        public async Task<List<Model>> GetModelsByBrandNameAsync(string brandName)
        {
            return await _context.Cars.
                Where(c => c.BrandName == brandName).
                GroupBy(car => car.ModelName).
                Select(group => new Model
                {
                    Id = group.First().Id,
                    BrandName = group.First().BrandName,
                    ModelName = group.First().ModelName,
                    LogoPath = group.First().ModelLogoPath
                }).
                ToListAsync();
        }
    }
}
