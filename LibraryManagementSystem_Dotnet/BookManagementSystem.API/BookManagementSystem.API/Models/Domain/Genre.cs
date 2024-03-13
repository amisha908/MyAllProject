using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.API.Models.Domain
{
    public class Genre
    {
        public Guid Id { get; set; }
        [Required] public string Name { get; set; }
        public string UrlHandle { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
