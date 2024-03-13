using BookManagementSystem.API.Data;
using BookManagementSystem.API.Models.Domain;
using BookManagementSystem.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystem.API.Repositories.Implementation
{
    public class ImageRepository : IImageRepository
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ApplicationDbContext dbContext;

        public ImageRepository(IWebHostEnvironment webHostEnvironment,
            IHttpContextAccessor httpContextAccessor,
            ApplicationDbContext dbContext)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.httpContextAccessor = httpContextAccessor;
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<BookImage>> GetAll()
        {
            return await dbContext.BookImages.ToListAsync();
        }

        public async Task<BookImage> Upload(IFormFile file, BookImage bookImage)
        {
            // 1- Upload the Image to API/Images
            var localPath = Path.Combine(webHostEnvironment.ContentRootPath, "Images", $"{bookImage.FileName}{bookImage.FileExtension}");
            using var stream = new FileStream(localPath, FileMode.Create);
            await file.CopyToAsync(stream);

            // 2-Update the database
            var httpRequest = httpContextAccessor.HttpContext.Request;
            var urlPath = $"{httpRequest.Scheme}://{httpRequest.Host}{httpRequest.PathBase}/Images/{bookImage.FileName}{bookImage.FileExtension}";
            bookImage.Url = urlPath;

            await dbContext.BookImages.AddAsync(bookImage);
            await dbContext.SaveChangesAsync();

            return bookImage;
        }
    }
}
