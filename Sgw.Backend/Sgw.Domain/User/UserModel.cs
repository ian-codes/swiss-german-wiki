using Sgw.Domain.Post;

namespace Sgw.Domain.User;

public class UserModel
{
    public UserModel(Guid guid, string username)
    {
        Guid = guid;
        Username = username;
    }

    public Guid Guid { get; set; }
    public string Username { get; }
    public List<PostModel> Words { get; set; } = new();
}