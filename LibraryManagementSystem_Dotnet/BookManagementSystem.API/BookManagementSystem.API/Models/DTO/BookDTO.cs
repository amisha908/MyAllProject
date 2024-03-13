using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.API.Models.DTO
{
    public class BookDTO
    {
        public Guid Id { get; set; }
        [Required] public string Name { get; set; }
        public string Description { get; set; }
        public double Ratings { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
        public string? LentByUserId { get; set; }
        public string? CurrentlyBorrowedByUserId { get; set; }
        public List<GenreDTO> Genres { get; set; } = new List<GenreDTO>();
    }
}
