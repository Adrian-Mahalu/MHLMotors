using Dapper;
using MHL_Motors.DataAccess.DatabaseContext;
using MHL_Motors.DataAccess.Repositories.Interfaces;
using MHL_Motors.Models.CarDataModels;
using System.Data;


namespace MHL_Motors.DataAccess.Repositories.Implementations
{
    public class CarsRepository : Repository<Car>, ICarsRepository
    {
        private readonly IDbConnection _dapperConnection;
        private readonly DataContext _context;
        //private readonly ICarFactory _carFactory;

        public CarsRepository(DataContext context, IDbConnection dapperConnection) : base(context)
        {
            _dapperConnection = dapperConnection;
            _context = context;
            //_carFactory = carFactory;
        }

        public async Task<List<Car>> GetAllCarsAsync()
        {
            var cars = await _dapperConnection.QueryAsync<Car>("SELECT * FROM Cars");

            return cars.ToList();
        }

        public async Task<Car> GetCarByIdAsync(Guid id)
        {
            return await _dapperConnection.QueryFirstAsync<Car>("SELECT * FROM Cars WHERE Id = @Id",
                new { Id = id });
        }
    }
}
