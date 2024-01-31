using Sgw.Domain.Post;
using Sgw.Domain.User;

namespace Sgw.Domain.Interfaces;

public interface IUserRepository
{
    public Task<UserModel> GetUserByUsername(string username);
    public Task<UserModel> GetUserByWord(PostModel post);
}