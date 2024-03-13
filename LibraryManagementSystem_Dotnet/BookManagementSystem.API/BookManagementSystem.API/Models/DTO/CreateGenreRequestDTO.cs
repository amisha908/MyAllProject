using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.API.Models.DTO
{
    public class CreateGenreRequestDTO
    {
        [Required] public string name { get; set; }
        public string urlHandle { get; set; }
    }
}
