using DataAccessLayer.models;
using DataAccessLayer.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Migrations;
using DataAccessLayer.Models;
using static System.Net.Mime.MediaTypeNames;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly APIDbContext _dbContext;

        public UserController(APIDbContext dbContext)
        {
            _dbContext = dbContext;

        }



       
        [HttpPost("register")]
        
        public async Task<IActionResult> AddUser([FromBody] Register UserRequest)
        {

            UserRequest.ID = Guid.NewGuid();
            _dbContext.Registers.Add(UserRequest);
            await _dbContext.SaveChangesAsync();
            return Ok(UserRequest);
        }





        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var registers = await _dbContext.Registers.ToListAsync();
            return Ok(registers);
        }
        [HttpGet("CheckEmailExists")]
        public async Task<IActionResult> CheckEmailExists(string email)
        {
            var  userExists = await _dbContext.Registers.AnyAsync(u => u.email == email);

            return Ok(userExists);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            // Check if user with the provided email exists
            var user = await _dbContext.Registers.FirstOrDefaultAsync(u => u.email == email);
            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }

            // Check if the password matches
            if (user.password != password)
            {
                return BadRequest(new { message = "Invalid password" });
            }

            // Store registration type in a variable (you can modify this logic as needed)
            string registrationType = user.registrationType;

            // You can perform additional authentication or generate a token here
            // For simplicity, let's return the registration type
            return Ok(new { registrationType });
        }
        [HttpGet("GetUserByEmail")]
        public async Task<IActionResult> GetUserByEmail([FromQuery] string email)
        {
            var user = await _dbContext.Registers.FirstOrDefaultAsync(u => u.email == email);

            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }

            var response = new
            {
                userId = user.ID,
                username = user.name
                // Add other properties as needed
            };

            return Ok(response);
        }




    }
}
