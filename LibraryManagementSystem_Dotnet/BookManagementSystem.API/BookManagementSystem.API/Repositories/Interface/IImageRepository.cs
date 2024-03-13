using BookManagementSystem.API.Models.Domain;

namespace BookManagementSystem.API.Repositories.Interface
{
    public interface IImageRepository
    {
        Task<BookImage> Upload(IFormFile file, BookImage bookImage);
        Task<IEnumerable<BookImage>> GetAll();
    }
}
