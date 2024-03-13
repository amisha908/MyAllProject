using BookManagementSystem.API.Models.Domain;
using Microsoft.AspNetCore.Identity;

namespace BookManagementSystem.API.Repositories.Interface
{
    public interface ITokenRepository
    {
        string CreateJwtToken(ApplicationUser user, List<string> roles);
    }
}
