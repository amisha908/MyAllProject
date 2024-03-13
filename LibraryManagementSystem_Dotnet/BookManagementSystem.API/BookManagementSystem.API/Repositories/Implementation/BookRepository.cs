using BookManagementSystem.API.Data;
using BookManagementSystem.API.Models.Domain;
using BookManagementSystem.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystem.API.Repositories.Implementation
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext dbContext;

        public BookRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Book> CreateAsync(Book book)
        {
            await dbContext.Books.AddAsync(book); 
            await dbContext.SaveChangesAsync();
            return book;
        }

        public async Task<Book?> DeleteAsync(Guid id)
        {
            var existingBook = await dbContext.Books.FirstOrDefaultAsync(x => x.Id == id);

            if (existingBook != null)
            {
                dbContext.Books.Remove(existingBook);
                await dbContext.SaveChangesAsync();
                return existingBook;
            }

            return null;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await dbContext.Books.Include(x=>x.Genres).ToListAsync();
        }

        public async Task<Book?> GetByIdAsync(Guid id)
        {
            return await dbContext.Books.Include(x => x.Genres).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Book?> GetByUrlHandleAsync(string urlHandle)
        {
            return await dbContext.Books.Include(x => x.Genres).FirstOrDefaultAsync(x => x.UrlHandle == urlHandle);
        }

        public async Task<Book?> UpdateAsync(Book book)
        {
            var existingBook = await dbContext.Books.Include(x => x.Genres)
                .FirstOrDefaultAsync(x => x.Id == book.Id);

            if (existingBook == null)
            {
                return null;
            }

            // Update Book
            dbContext.Entry(existingBook).CurrentValues.SetValues(book);

            // Update Genres
            existingBook.Genres = book.Genres;

            await dbContext.SaveChangesAsync();

            return book;
        }
    }
}
