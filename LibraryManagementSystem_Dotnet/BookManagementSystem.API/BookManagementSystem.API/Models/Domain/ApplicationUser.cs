using Microsoft.AspNetCore.Identity;

namespace BookManagementSystem.API.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public int TokensAvailable { get; set; }
    }
}
