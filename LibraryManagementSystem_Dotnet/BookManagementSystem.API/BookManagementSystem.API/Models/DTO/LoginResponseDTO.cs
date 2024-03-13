namespace BookManagementSystem.API.Models.DTO
{
    public class LoginResponseDTO
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public List<string> Roles { get; set; }
        public string Name { get; set; }
        public int TokensAvailable { get; set; }
    }
}
