using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
    {
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
            Id = 1,
            Title = "Product 2",
            Description = "lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            ImageUrl = "https://via.placeholder.com/150",
            Price = 100.99m
        },
        new Product
        {
            Id = 1,
            Title = "Product 3",
            Description = "lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            ImageUrl = "https://via.placeholder.com/150",
            Price = 100.99m
        },
    };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() => Ok(Products);

    }
}
