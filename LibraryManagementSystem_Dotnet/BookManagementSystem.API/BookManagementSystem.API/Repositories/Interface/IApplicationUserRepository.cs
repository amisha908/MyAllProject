using BookManagementSystem.API.Models.Domain;

namespace BookManagementSystem.API.Repositories.Interface
{
    public interface IApplicationUserRepository
    {
        Task<ApplicationUser?> GetByIdAsync(string id);
        Task<ApplicationUser?> UpdateAsync(ApplicationUser applicationUser);
    }
}
