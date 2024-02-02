using Microsoft.EntityFrameworkCore;
using Sgw.Domain.Interfaces;
using Sgw.Domain.Post;
using Sgw.Domain.User;
using Sgw.Persistence.DataModels.User;
using Sgw.Persistence.Persistence;

namespace Sgw.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    public UserRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
        _users = dbContext.Set<UserData>();
    }
    
    private readonly DatabaseContext _dbContext;
    private readonly DbSet<UserData> _users;


    public async Task<bool> CreateUser(UserModel userModel, string hashedPassword)
    {
        var userDataModel = new UserData(userModel.Guid, userModel.Username, hashedPassword);
        await _users.AddAsync(userDataModel);
        return await _dbContext.SaveChangesAsync() > 0;
    }
    
    public Task<UserModel> GetUserByUsername(string username)
    {
        throw new NotImplementedException();
    }

    public Task<UserModel> GetUserByWord(PostModel post)
    {
        throw new NotImplementedException();
    }
}