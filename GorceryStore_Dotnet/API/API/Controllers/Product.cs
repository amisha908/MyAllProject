using DataAccessLayer.models;
using DataAccessLayer.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly APIDbContext _dbContext;
       
        public ProductController(APIDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _dbContext.Products.ToListAsync();
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product productRequest)
        {
            productRequest.ID = Guid.NewGuid();
            await _dbContext.Products.AddAsync(productRequest);
            await _dbContext.SaveChangesAsync();
            return Ok(productRequest);
        }

        [HttpPut("{productId}")]
        public async Task<IActionResult> EditProduct(Guid productId, [FromBody] Product productRequest)
        {
            var product = await _dbContext.Products.FindAsync(productId);

            if (product == null)
            {
                return NotFound(new { message = "Product not found" });
            }

            product.ProductName = productRequest.ProductName;
            product.Price = productRequest.Price;
            product.Description = productRequest.Description;
            product.Category = productRequest.Category;
            product.AvailableQuantity = productRequest.AvailableQuantity;
            product.Image = productRequest.Image;
            product.Discount = productRequest.Discount;
            product.Specification = productRequest.Specification;


            
        // Update other properties as needed

        await _dbContext.SaveChangesAsync();

            return Ok(product);
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> DeleteProduct(Guid productId)
        {
            var product = await _dbContext.Products.FindAsync(productId);

            if (product == null)
            {
                return NotFound(new { message = "Product not found" });
            }

            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();

            return Ok(new { message = "Product deleted successfully" });
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductById(Guid productId)
        {
            var product = await _dbContext.Products.FindAsync(productId);

            if (product == null)
            {
                return NotFound(new { message = "Product not found" });
            }

            return Ok(product);
        }
    }
}
    