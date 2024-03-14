using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Models;
using static System.Net.Mime.MediaTypeNames;
using DataAccessLayer.data;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RatingsController : ControllerBase
    {
        private readonly APIDbContext _dbContext;

        public RatingsController(APIDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        [HttpPost("AddRatings")]
        public IActionResult AddRatings([FromBody] Ratings request)
        {
            if (ModelState.IsValid)
            {
                var rating = new Ratings
                {
                    RatingID = Guid.NewGuid(),
                    rating = request.rating,
                    productId = request.productId
                };

                _dbContext.Rating.Add(rating);
                _dbContext.SaveChanges();

                return Ok("Rating added successfully.");
            }
            else
            {
                return BadRequest("Invalid rating request.");
            }
        }


        [HttpGet("GetRating/{productId}")]
        public IActionResult GetRating(string productId)
        {
            var ratings = _dbContext.Rating.Where(r => r.productId == productId).ToList();

            if (ratings.Count == 0)
            {
                return Ok(0);
            }

            var averageRating = ratings.Average(r => r.rating);

            return Ok(averageRating);
        }

    }
}