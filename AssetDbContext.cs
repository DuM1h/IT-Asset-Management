using Microsoft.EntityFrameworkCore;

namespace IT_Asset_Management
{
    public class AssetDbContext : DbContext
    {
        public AssetDbContext(DbContextOptions<AssetDbContext> options) : base(options)
        {
        }
        public DbSet<Entities.Employee> Employees { get; set; }
        public DbSet<Entities.Equipment> Equipments { get; set; }
    }
}
