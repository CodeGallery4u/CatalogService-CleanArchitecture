using Application.Common.Interfaces;
using Core.Model;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace TestUtility
{
    public static class Utility
    {
        public static ApplicationDbContext CreateDatabaseContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase(databaseName: "ShoppingCart.db");
            var context = new ApplicationDbContext(optionsBuilder.Options);
            return context;
        }

        public static void SeedCategories(ApplicationDbContext context)
        {
            context.Database.EnsureDeleted();
            List<Category> categories = new List<Category>()
            {
                new Category(){ Id = 1, ImageUrl="",Name="Moobile" },
                new Category(){ Id = 2, ImageUrl="",Name="Laptop" },
            };

            context.Categories.AddRange(categories);
            context.SaveChanges();
         
        }

        public static void SeedProduct(ApplicationDbContext context)
        {
            context.Database.EnsureDeleted();

            List<Category> categories = new List<Category>()
            {
                new Category(){ Id = 1, ImageUrl="",Name="Moobile" },
                new Category(){ Id = 2, ImageUrl="",Name="Laptop" },
            };

            context.Categories.AddRange(categories);

            List<Product> products = new List<Product>() {
            new Product(){ Id = 1, CategoryId = 1, Name="iPhone 14" ,Description="Apple Phone", Amount = 100, Price=85400  },
            new Product(){ Id = 2, CategoryId = 1, Name="S22 Ultra" ,Description="Samsung's Phone", Amount = 20, Price=75400 },
            new Product(){ Id = 3, CategoryId = 2, Name="HP Ultra Book" ,Description="HP Laptop", Amount = 10, Price=6900 },
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }

    }
}