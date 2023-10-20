using Microsoft.Extensions.Options;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Product 1",
                    Description = "lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ImageUrl = "https://via.placeholder.com/150",
                    Price = 100.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Product 2",
                    Description = "lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ImageUrl = "https://via.placeholder.com/150",
                    Price = 100.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Product 3",
                    Description = "lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ImageUrl = "https://via.placeholder.com/150",
                    Price = 100.99m
                }
            );
        }

        public DbSet<Product> Products { get; set; }

    }
}
