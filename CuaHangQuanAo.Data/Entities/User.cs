namespace CuaHangQuanAo.Data.Entities;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string? RefreshToken { get; set; }
    public DateTime? TokenExpires { get; set; }

    public int RoleId { get; set; }
    public Role? Role { get; set; }
}