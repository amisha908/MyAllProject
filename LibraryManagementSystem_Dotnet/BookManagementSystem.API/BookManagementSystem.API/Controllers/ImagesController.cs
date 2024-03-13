using BookManagementSystem.API.Models.Domain;
using BookManagementSystem.API.Models.DTO;
using BookManagementSystem.API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository imageRepository;

        public ImagesController(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllImages()
        {
            // call image repository to get all images
            var images = await imageRepository.GetAll();

            // Convert Domain model to DTO
            var response = new List<BookImageDTO>();
            foreach (var image in images)
            {
                response.Add(new BookImageDTO
                {
                    Id = image.Id,
                    Title = image.Title,
                    FileExtension = image.FileExtension,
                    FileName = image.FileName,
                    Url = image.Url
                });
            }

            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> UploadImage([FromForm] IFormFile file,
            [FromForm] string fileName, [FromForm] string title)
        {
            ValidateFileUpload(file);

            if (ModelState.IsValid)
            {
                // File upload
                var bookImage = new BookImage
                {
                    FileExtension = Path.GetExtension(file.FileName).ToLower(),
                    FileName = fileName,
                    Title = title,
                };

                bookImage = await imageRepository.Upload(file, bookImage);

                // Convert Domain Model to DTO
                var response = new BookImageDTO
                {
                    Id = bookImage.Id,
                    Title = bookImage.Title,
                    FileExtension = bookImage.FileExtension,
                    FileName = bookImage.FileName,
                    Url = bookImage.Url
                };

                return Ok(response);
            }

            return BadRequest(ModelState);
        }

        private void ValidateFileUpload(IFormFile file)
        {
            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png" };

            if (!allowedExtensions.Contains(Path.GetExtension(file.FileName).ToLower()))
            {
                ModelState.AddModelError("file", "Unsupported file format");
            }

            if (file.Length > 10485760)
            {
                ModelState.AddModelError("file", "File size cannot be more than 10MB");
            }
        }
    }
}
