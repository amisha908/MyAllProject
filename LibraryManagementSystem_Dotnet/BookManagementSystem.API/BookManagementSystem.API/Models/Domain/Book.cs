using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.API.Models.Domain
{
    public class Book
    {
        int myProperty;

        // public int MyProperty { get;} //read only 
        /* public int MyProperty { 
            set
            {
                myProperty=value
            }
        } //write only*/
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
        public ICollection<Genre> Genres { get; set; }
    }
}
