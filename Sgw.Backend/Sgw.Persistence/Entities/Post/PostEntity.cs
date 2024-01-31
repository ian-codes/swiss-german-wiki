using Sgw.Persistence.Entities.User;

namespace Sgw.Persistence.Entities.Post;

public class PostEntity
{
    public Guid Guid { get; set; }
    public string Word { get; set; }
    public string DefinitionDE { get; set; }
    public string DefinitionEN { get; set; }
    public string Example { get; set; }
    
    public UserEntity Author { get; set; }
}