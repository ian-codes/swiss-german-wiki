namespace Sgw.Persistence.DataModels.User;

public sealed class UserData
{
    public UserData(Guid guid, string username, string hashedPassword)
    {
        Guid = guid;
        Username = username;
        HashedPassword = hashedPassword;
    }

    public Guid Guid { get; set; }
    public string Username { get; set; }
    public string HashedPassword { get; set; }
}