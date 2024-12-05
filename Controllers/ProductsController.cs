using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct(){
            var DomainData = await productRepository.GetAllProductAsync();
            return Ok(DomainData);
        }
    }
}