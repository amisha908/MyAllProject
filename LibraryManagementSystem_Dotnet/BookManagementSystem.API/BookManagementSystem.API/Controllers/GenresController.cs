using BookManagementSystem.API.Data;
using BookManagementSystem.API.Models.Domain;
using BookManagementSystem.API.Models.DTO;
using BookManagementSystem.API.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreRepository genreRepository;

        public GenresController(IGenreRepository genreRepository)
        {
            this.genreRepository = genreRepository;
        }
        [HttpPost]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> CreateGenre(CreateGenreRequestDTO request)
        
        {
            //Map DTO to Domain Model
            var genre = new Genre
            {
                Name = request.name,
                UrlHandle = request.urlHandle
            };

            await genreRepository.CreateAsync(genre);

            //Map Domain Model to DTO
            var response = new GenreDTO
            {
                Id = genre.Id,
                Name = genre.Name,
                UrlHandle = genre.UrlHandle
            };

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGenres()
        {
           var genres =  await genreRepository.GetAllAsync();

            //Map Domain Model to DTO
            var response = new List<GenreDTO>();
            foreach (var genre in genres) 
            {
                response.Add(new GenreDTO
                {
                    Id = genre.Id,
                    Name = genre.Name,
                    UrlHandle = genre.UrlHandle
                });
            }
            return Ok(response); 
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetGenreById([FromRoute] Guid id)
        {
            var existingGenre = await genreRepository.GetById(id);

            if (existingGenre is null)
            {
                return NotFound();
            }

            var response = new GenreDTO
            {
                Id = existingGenre.Id,
                Name = existingGenre.Name,
                UrlHandle = existingGenre.UrlHandle
            };

            return Ok(response);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> EditGenre([FromRoute] Guid id, UpdateGenreRequestDTO request)
        {
            // Convert DTO to Domain Model
            var genre = new Genre
            {
                Id = id,
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

            genre = await genreRepository.UpdateAsync(genre);

            if (genre == null)
            {
                return NotFound();
            }

            // Convert Domain model to DTO
            var response = new GenreDTO
            {
                Id = genre.Id,
                Name = genre.Name,
                UrlHandle = genre.UrlHandle
            };

            return Ok(response);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> DeleteGenre([FromRoute] Guid id)
        {
            var genre = await genreRepository.DeleteAsync(id);

            if (genre is null)
            {
                return NotFound();
            }

            // Convert Domain model to DTO
            var response = new GenreDTO
            {
                Id = genre.Id,
                Name = genre.Name,
                UrlHandle = genre.UrlHandle
            };

            return Ok(response);
        }
    }
}
    

