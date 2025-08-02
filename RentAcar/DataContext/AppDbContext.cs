using Microsoft.EntityFrameworkCore;
using RentAcar.DataContext.Entities;
namespace RentaCarMvc.DataContext
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Model> Models { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
    }

}
