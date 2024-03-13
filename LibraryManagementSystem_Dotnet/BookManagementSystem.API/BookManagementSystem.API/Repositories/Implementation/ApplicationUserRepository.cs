using BookManagementSystem.API.Data;
using BookManagementSystem.API.Models.Domain;
using BookManagementSystem.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystem.API.Repositories.Implementation
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ApplicationUserRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<ApplicationUser?> GetByIdAsync(string id)
        {
            return await dbContext.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ApplicationUser?> UpdateAsync(ApplicationUser applicationUser)
        {
            var existingApplicationUser = await dbContext.ApplicationUsers
                .FirstOrDefaultAsync(x => x.Id == applicationUser.Id);

            if (existingApplicationUser == null)
            {
                return null;
            }

            // Update AplicationUser
            dbContext.Entry(existingApplicationUser).CurrentValues.SetValues(applicationUser);

            await dbContext.SaveChangesAsync();

            return applicationUser;
        }
    }
}
