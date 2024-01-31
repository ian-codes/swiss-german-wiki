using Sgw.Domain.Interfaces;
using Sgw.Domain.Post;
using Sgw.Domain.User;
using Sgw.Persistence.Persistence;

namespace Sgw.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    public UserRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    private readonly DatabaseContext _dbContext;

    
    public Task<UserModel> GetUserByUsername(string username)
    {
        throw new NotImplementedException();
    }

    public Task<UserModel> GetUserByWord(PostModel post)
    {
        throw new NotImplementedException();
    }
}