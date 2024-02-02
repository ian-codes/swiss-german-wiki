namespace Sgw.Application.DTOs.Users;

public sealed class UserCreateDto
{
    public UserCreateDto(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public string Username { get; }
    public string Password { get; }
}