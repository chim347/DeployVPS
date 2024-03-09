public class AuthResponse
{
    public string? Id { get; set; }
    public string? Username { get; set;}
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public List<string> ListRoles { get; set; } = null!;
    public string? Token { get; set; }
}
