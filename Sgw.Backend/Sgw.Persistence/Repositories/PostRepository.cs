using Microsoft.EntityFrameworkCore;
using Sgw.Domain.Interfaces;
using Sgw.Domain.Post;
using Sgw.Domain.User;
using Sgw.Persistence.Entities.Post;
using Sgw.Persistence.Persistence;

namespace Sgw.Persistence.Repositories;

public class PostRepository : IPostRepository
{
    public PostRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
        _words = dbContext.Posts;
    }
    
    private readonly DatabaseContext _dbContext;
    private readonly DbSet<PostEntity> _words;
    
    
    public Task<List<PostModel>> FindPostsByWord(string word)
    {
        throw new NotImplementedException();
    }

    public Task<PostModel> GetWordByDefinition(string definition)
    {
        throw new NotImplementedException();
    }

    public Task<List<PostModel>> GetWordsByUser(UserModel user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CreateWord(PostModel post)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DoesWordAlreadyExist(string word)
    {
        throw new NotImplementedException();
    }
}