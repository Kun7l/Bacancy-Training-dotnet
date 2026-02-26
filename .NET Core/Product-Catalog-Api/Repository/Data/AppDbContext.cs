using Microsoft.EntityFrameworkCore;
using Product_Catalog_Api.Repository.Model;

namespace Product_Catalog_Api.Repository.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext (options)
    {
        public DbSet<Product> Products { get; set; }
    }
}
