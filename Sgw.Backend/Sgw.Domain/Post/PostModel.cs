using Sgw.Domain.User;

namespace Sgw.Domain.Post;

public class PostModel
{
    public PostModel(Guid guid, string word, string definitionDe, string definitionEn, string example, UserModel author)
    {
        Guid = guid;
        Word = word;
        DefinitionDE = definitionDe;
        DefinitionEN = definitionEn;
        Example = example;
        Author = author;
    }

    public Guid Guid { get; set; }
    public string Word { get; set; }
    public string DefinitionDE { get; set; }
    public string DefinitionEN { get; set; }
    public string Example { get; set; }
    public UserModel Author { get; set; }
}