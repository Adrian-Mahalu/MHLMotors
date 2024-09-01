using MHL_Motors.DataAccess.DatabaseContext;
using MHL_Motors.DataAccess.Repositories.Implementations;
using MHL_Motors.DataAccess.Repositories.Interfaces;
using System.Data;

namespace MHL_Motors.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private readonly IDbConnection _dapperConnection;
        public ICarsRepository CarsRepository { get; }
        public IBrandsRepository BrandsRepository { get; }
        public IEnginesRepository EnginesRepository { get; }
        public IGenerationsRepository GenerationsRepository { get; }
        public IModelsRepository ModelsRepository { get; }

        public UnitOfWork(DataContext context, IDbConnection dapperConnection)
        {
            _context = context;
            _dapperConnection = dapperConnection;

            CarsRepository = new CarsRepository(_context, _dapperConnection);
            BrandsRepository = new BrandsRepository(_context, _dapperConnection);
            EnginesRepository = new EnginesRepository(_context, _dapperConnection);
            GenerationsRepository = new GenerationsRepository(_context, _dapperConnection);
            ModelsRepository = new ModelsRepository(_context, _dapperConnection);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
