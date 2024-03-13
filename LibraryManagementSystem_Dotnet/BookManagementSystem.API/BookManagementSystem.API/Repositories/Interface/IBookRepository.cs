using BookManagementSystem.API.Models.Domain;

namespace BookManagementSystem.API.Repositories.Interface
{
    public interface IBookRepository
    {
         Task<Book> CreateAsync(Book book );
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(Guid id);
        Task<Book?> GetByUrlHandleAsync(string urlHandle);
        Task<Book?> UpdateAsync(Book book);
        Task<Book?> DeleteAsync(Guid id);
    }
}
