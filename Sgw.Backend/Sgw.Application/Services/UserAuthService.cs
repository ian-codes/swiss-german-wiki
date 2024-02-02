using Sgw.Application.DTOs.Users;
using Sgw.Application.Interfaces;
using BC = BCrypt.Net.BCrypt;

namespace Sgw.Application.Services;

public sealed class UserAuthService : IUserAuthService
{
    public string HashPassword(string password)
    {
        return BC.HashPassword(password, 14);
    }
    
    public bool ValidateUserData(UserCreateDto user)
    {
        if (string.IsNullOrEmpty(user.Password) || user.Password.Length < 8)
            return false;

        return !string.IsNullOrEmpty(user.Username) && user.Username.Length >= 3;
    }
}