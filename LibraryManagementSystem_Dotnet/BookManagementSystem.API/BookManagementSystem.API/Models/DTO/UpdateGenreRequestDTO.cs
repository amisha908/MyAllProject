using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.API.Models.DTO
{
    public class UpdateGenreRequestDTO
    {
        [Required] public string Name { get; set; }
        public string UrlHandle { get; set; }
    }
}
