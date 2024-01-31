using Sgw.Domain.Post;
using Sgw.Domain.User;

namespace Sgw.Domain.Interfaces;

public interface IPostRepository
{
    public Task<List<PostModel>> FindPostsByWord(string word);
    public Task<PostModel> GetWordByDefinition(string definition);
    public Task<List<PostModel>> GetWordsByUser(UserModel user);
    public Task<bool> CreateWord(PostModel post);
    public Task<bool> DoesWordAlreadyExist(string word);
}