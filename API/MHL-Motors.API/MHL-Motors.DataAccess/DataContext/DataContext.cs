using MHL_Motors.Models;
using MHL_Motors.Models.CarDataModels;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace MHL_Motors.DataAccess.DatabaseContext
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=NBKR004465\\SQLEXPRESS;Database=MHLMotorsDBTest01;Trusted_Connection=true;TrustServerCertificate=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Generation> Generations { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
