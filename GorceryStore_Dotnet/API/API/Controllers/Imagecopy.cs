using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ImageController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("upload-image")]
        public IActionResult UploadImage(IFormFile image)
        {
            if (image == null || image.Length == 0)
            {
                return BadRequest("No file uploaded");
            }

            var uploadsFolder = @"C:\Users\shreyanshnema\Documents\Exit project\Full stack UI\FullStack.UI\src\assets\images";
            var uniqueFileName = $"{DateTime.Now.Ticks}-{Guid.NewGuid().ToString()}{Path.GetExtension(image.FileName)}";
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                image.CopyTo(fileStream);
            }

            var imageUrl = $"/assets/images/{uniqueFileName}";

            return Ok(new { imageUrl });
        }


    }
}