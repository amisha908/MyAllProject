using BookManagementSystem.API.Data;
using BookManagementSystem.API.Models.Domain;
using BookManagementSystem.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystem.API.Repositories.Implementation
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext dbContext;

        public GenreRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Genre> CreateAsync(Genre genre)
        {
            await dbContext.Genres.AddAsync(genre);
            await dbContext.SaveChangesAsync();

            return genre;
        }

        public async Task<Genre?> DeleteAsync(Guid id)
        {
            var existingGenre = await dbContext.Genres.FirstOrDefaultAsync(x => x.Id == id);

            if (existingGenre is null)
            {
                return null;
            }

            dbContext.Genres.Remove(existingGenre);
            await dbContext.SaveChangesAsync();
            return existingGenre;
        }

        public async Task<IEnumerable<Genre>> GetAllAsync()
        {
            return await dbContext.Genres.ToListAsync();
        }

        public async Task<Genre?> GetById(Guid id)
        {
            return await dbContext.Genres.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Genre?> UpdateAsync(Genre genre)
        {
            var existingGenre = await dbContext.Genres.FirstOrDefaultAsync(x => x.Id == genre.Id);

            if (existingGenre != null)
            {
                dbContext.Entry(existingGenre).CurrentValues.SetValues(genre);
                await dbContext.SaveChangesAsync();
                return genre;
            }

            return null;
        }
    }
}
    

