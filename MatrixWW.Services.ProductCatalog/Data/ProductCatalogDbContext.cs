using MatrixWW.Services.ProductCatalog.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MatrixWW.Services.ProductCatalog.Data
{
    public class ProductCatalogDbContext : DbContext 
    {
        public ProductCatalogDbContext(DbContextOptions<ProductCatalogDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.SeedData();
        }
    }
}
