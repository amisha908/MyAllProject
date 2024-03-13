using BookManagementSystem.API.Models.Domain;

namespace BookManagementSystem.API.Repositories.Interface
{
    public interface IGenreRepository
    {
        Task<Genre> CreateAsync(Genre genre);

        Task<IEnumerable<Genre>> GetAllAsync();

        Task<Genre?> GetById(Guid id);

        Task<Genre?> UpdateAsync(Genre genre);

        Task<Genre?> DeleteAsync(Guid id);
    }
}
