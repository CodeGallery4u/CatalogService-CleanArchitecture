using Application.Common.Interfaces;
using Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public Task<int> SaveDbChangesAsync()
        {
            return SaveChangesAsync();
        }

    }
}