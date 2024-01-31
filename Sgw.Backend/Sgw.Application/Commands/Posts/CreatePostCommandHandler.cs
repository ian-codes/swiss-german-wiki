using MediatR;
using Sgw.Domain.Interfaces;
using Sgw.Domain.Post;

namespace Sgw.Application.Commands.Posts;

public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, bool>
{
    public CreatePostCommandHandler(IUserRepository userRepository, IPostRepository postRepository)
    {
        _userRepository = userRepository;
        _postRepository = postRepository;
    }
    
    private readonly IUserRepository _userRepository;
    private readonly IPostRepository _postRepository;
    

    public async Task<bool> Handle(CreatePostCommand request, CancellationToken cancellationToken)
    {
        if (await _postRepository.DoesWordAlreadyExist(request.PostCreateDto.Word))
            return false;
        
        var author = await _userRepository.GetUserByUsername(request.PostCreateDto.AuthorUsername);

        var wordModel = new PostModel(
            Guid.NewGuid(),
            request.PostCreateDto.Word,
            request.PostCreateDto.DefinitionDE,
            request.PostCreateDto.DefinitionEN,
            request.PostCreateDto.Example,
            author);

        return await _postRepository.CreateWord(wordModel);
    }
}