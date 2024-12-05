using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Data;
using ecommerce.Models;
using Microsoft.EntityFrameworkCore;


namespace ecommerce.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EcommerceDbContext ecommerceDbContext;
        public ProductRepository(EcommerceDbContext ecommerceDbContext)
        {
            this.ecommerceDbContext = ecommerceDbContext;
            
        }
        public Task<Product> CreateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> DeleteProdctuAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAllProductAsync()
        {
            return await ecommerceDbContext.Products.ToListAsync();
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProdcutAsync(int Id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}