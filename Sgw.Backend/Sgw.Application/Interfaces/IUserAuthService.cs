using Sgw.Application.DTOs.Users;

namespace Sgw.Application.Interfaces;

public interface IUserAuthService
{
    public string HashPassword(string password);
    public bool ValidateUserData(UserCreateDto userCreateDto);
}