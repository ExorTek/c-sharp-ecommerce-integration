using Integration.Entities.Concrete.DataBase;
using Microsoft.EntityFrameworkCore;

namespace Integration.DataAccess.Concrete
{
    public class IntegrationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Integration;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
    }
}