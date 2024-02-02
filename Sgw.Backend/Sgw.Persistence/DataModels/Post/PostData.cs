using Sgw.Persistence.DataModels.User;

namespace Sgw.Persistence.DataModels.Post;

public class PostData
{
    public Guid Guid { get; set; }
    public string Word { get; set; }
    public string DefinitionDE { get; set; }
    public string DefinitionEN { get; set; }
    public string Example { get; set; }
    
    public UserData Author { get; set; }
}