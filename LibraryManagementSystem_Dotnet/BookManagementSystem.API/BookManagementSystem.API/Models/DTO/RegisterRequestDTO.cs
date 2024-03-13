namespace BookManagementSystem.API.Models.DTO
{
    public class RegisterRequestDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int TokensAvailable { get; set; }
    }
}
