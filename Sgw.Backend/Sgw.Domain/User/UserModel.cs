using Sgw.Domain.Post;

namespace Sgw.Domain.User;

public class UserModel
{
    public UserModel(string username)
    {
        Username = username;
    }
    
    public string Username { get; }
    public List<PostModel> Words { get; set; } = new();
}