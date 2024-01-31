using MediatR;
using Sgw.Application.DTOs.Posts;
using Sgw.Domain.Interfaces;

namespace Sgw.Application.Queries;

public class GetWordByWordQueryHandler : IRequestHandler<FindWordsByWordQuery, List<PostViewDto>>
{
    public GetWordByWordQueryHandler(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }
    
    private readonly IPostRepository _postRepository;
    

    public async Task<List<PostViewDto>> Handle(FindWordsByWordQuery request, CancellationToken cancellationToken)
    {
        var words = await _postRepository.FindPostsByWord(request.word);

        var wordViewDtos = new List<PostViewDto>();

        foreach (var wordModel in words)
        {
            var wordViewDto = new PostViewDto
            {
                Word = wordModel.Word,
                DefinitionDE = wordModel.DefinitionDE,
                DefinitionEN = wordModel.DefinitionEN,
                AuthorUsername = wordModel.Author.Username
            };

            wordViewDtos.Add(wordViewDto);
        }

        return wordViewDtos;
    }
}