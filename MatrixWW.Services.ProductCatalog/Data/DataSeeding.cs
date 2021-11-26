using MatrixWW.Services.ProductCatalog.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MatrixWW.Services.ProductCatalog.Data
{
    public static class DataSeeding
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            //Brands
            var brands = new List<Brand>
            {
                new Brand { Id = 1, Name = "Gucci" },
                new Brand { Id = 2, Name = "Nike"},
                new Brand { Id = 3, Name = "Adidas" }
            };
            builder.Entity<Brand>().HasData(brands);

            //Categories
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "T-Shirt"},
                new Category { Id = 2, Name = "Hoodie"},
                new Category { Id = 3, Name = "Broek"}
            };
            builder.Entity<Category>().HasData(categories);

            //Products
            var products = new List<Product>
            {
                //Gucci
                new Product { Id = 1, Name = "Gucci T-Shirt", Price = 90, BrandId = brands[0].Id, CategoryId = categories[0].Id, Description = "Een wit T-Shirt van Gucci" },
                new Product { Id = 2, Name = "Gucci Hoodie", Price = 150, BrandId = brands[0].Id, CategoryId = categories[1].Id, Description = "Een bruine Hoodie van Gucci" },
                new Product { Id = 3, Name = "Gucci Broek", Price = 190, BrandId = brands[0].Id, CategoryId = categories[2].Id, Description = "Een zwarte broek van Gucci" },
                //Nike
                new Product { Id = 4, Name = "Nike T-Shirt", Price = 80, BrandId = brands[1].Id, CategoryId = categories[0].Id, Description = "Een wit T-Shirt van Nike" },
                new Product { Id = 5, Name = "Nike Hoodie", Price = 140, BrandId = brands[1].Id, CategoryId = categories[1].Id, Description = "Een bruine Hoodie van Nike" },
                new Product { Id = 6, Name = "Nike Broek", Price = 180, BrandId = brands[1].Id, CategoryId = categories[2].Id, Description = "Een zwarte broek van Nike" },
                //Adidas
                new Product { Id = 7, Name = "Adidas T-Shirt", Price = 70, BrandId = brands[2].Id, CategoryId = categories[0].Id, Description = "Een wit T-Shirt van Adidas" },
                new Product { Id = 8, Name = "Adidas Hoodie", Price = 130, BrandId = brands[2].Id, CategoryId = categories[1].Id, Description = "Een bruine Hoodie van Adidas" },
                new Product { Id = 9, Name = "Adidas Broek", Price = 170, BrandId = brands[2].Id, CategoryId = categories[2].Id, Description = "Een zwarte broek van Adidas" },
            };
            builder.Entity<Product>().HasData(products);

            return builder;
        }
    }
}
