﻿namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products
                .Include(product => product.Variants)
                .ThenInclude(variant => variant.ProductType)
                .FirstOrDefaultAsync(product => product.Id == productId);
            if (product == null)
            {
                response.Success = false;
                response.Message = "Product not found.";
            }
            else
            {
                response.Data = product;
            }
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.Include(product => product.Variants).ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products
                    .Where(product => product.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                    .Include(product => product.Variants)
                    .ToListAsync()
            };
            return response;
        }
    }
}
