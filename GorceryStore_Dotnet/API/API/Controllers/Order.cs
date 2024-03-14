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
    public class OrderController : ControllerBase
    {
        private readonly APIDbContext _dbContext;

        public OrderController(APIDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        [HttpPost("addorder")]
        public async Task<IActionResult> AddOrder([FromBody] Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Generate a new OrderID
            order.OrderID = Guid.NewGuid();

            // Set the current date and time
            order.OrderTime = DateTime.Now;
            order.OrderDate = DateTime.Today;

            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }


        [HttpGet("getorders")]
        public IActionResult GetOrders(string userId)
        {
            var orders = _dbContext.Orders
                .Where(o => o.UserID == userId)
                .ToList();

            return Ok(orders);
        }

        [HttpGet("getallorders")]
        public IActionResult GetAllOrders()
        {
            var orders = _dbContext.Orders.ToList();
            return Ok(orders);
        }



    }
}