using MHL_Motors.DataAccess.DatabaseContext;
using MHL_Motors.DataAccess.Repositories.Interfaces;
using MHL_Motors.Models.CarDataModels;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace MHL_Motors.DataAccess.Repositories.Implementations
{
    public class BrandsRepository : Repository<Brand>, IBrandsRepository
    {
        private readonly IDbConnection _dapperConnection;
        private DataContext _context;

        public BrandsRepository(DataContext context, IDbConnection dapperConnection) : base(context)
        {
            _dapperConnection = dapperConnection;
            _context = context;
        }

        public async Task<List<Brand>> GetAllBrandsAsync()
        {
            return await _context.Cars.
                        GroupBy(car => car.BrandName).
                        Select(group => new Brand
                        {
                            Id = group.First().Id,
                            BrandName = group.First().BrandName,
                            IsCommonBrand = group.First().IsCommonBrand,
                            LogoPath = group.First().BrandLogoPath
                        }).
                            ToListAsync();
        }

        public async Task<List<Brand>> GetCommonBrandsAsync()
        {
            return await _context.Cars.
                       Where(c => c.IsCommonBrand == true).
                       GroupBy(car => car.BrandName).
                       Select(group => new Brand
                       {
                           Id = group.First().Id,
                           BrandName = group.First().BrandName,
                           IsCommonBrand = group.First().IsCommonBrand
                       }).
                       ToListAsync();
        }
    }
}
