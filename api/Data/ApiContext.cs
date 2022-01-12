using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Jake Busey",
                    Description = "Gary Busey's dangerously insane brother",
                    Price = 1m,
                    rating = 0
                });
        }
    }
}
