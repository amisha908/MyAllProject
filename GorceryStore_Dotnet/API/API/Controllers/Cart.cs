using DataAccessLayer.models;
using DataAccessLayer.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using DataAccessLayer.Migrations;
using DataAccessLayer.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly APIDbContext _dbContext;

        public CartController(APIDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        [HttpPost("addtocart")]
        public async Task<IActionResult> AddToCart([FromBody] Cart cart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Generate a new CartID
            cart.CartID = Guid.NewGuid();

            _dbContext.Carts.Add(cart);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
        [HttpGet("getCartItems")]
        public IActionResult GetCartItems(string userId)
        {
            var cartItems = _dbContext.Carts
                .Where(c => c.UserID == userId)
                .GroupBy(c => c.productId)
                .Select(g => new
                {
                    ProductId = g.Key,
                    TotalQuantity = g.Sum(c => c.productQuantity)
                })
                .ToList();

            return Ok(cartItems);
        }

        [HttpPost("emptyusercart")]
        public async Task<IActionResult> EmptyUserCart(string userId)
        {
            // Get the cart items for the specified user
            var cartItems = await _dbContext.Carts.Where(c => c.UserID == userId).ToListAsync();

            // Remove the cart items from the database
            _dbContext.Carts.RemoveRange(cartItems);

            await _dbContext.SaveChangesAsync();

            return Ok();
        }




    }
}

