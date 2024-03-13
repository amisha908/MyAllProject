using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.API.Models.DTO
{
    public class GenreDTO
    {
        public Guid Id { get; set; }
        [Required] public string Name { get; set; }
        public string UrlHandle { get; set; }
    }
}
