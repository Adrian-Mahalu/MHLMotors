using MHL_Motors.DataAccess.Repositories.Interfaces;

namespace MHL_Motors.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICarsRepository CarsRepository { get; }
        IBrandsRepository BrandsRepository { get; }
        IEnginesRepository EnginesRepository { get; }
        IGenerationsRepository GenerationsRepository { get; }
        IModelsRepository ModelsRepository { get; }
        Task SaveChangesAsync();
    }
}
