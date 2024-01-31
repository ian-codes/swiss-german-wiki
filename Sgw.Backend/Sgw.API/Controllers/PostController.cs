using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sgw.Application.Commands.Posts;
using Sgw.Application.DTOs.Posts;
using Sgw.Application.Queries;

namespace Sgw.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PostController : ControllerBase
{
    public PostController(ISender sender)
    {
        _sender = sender;
    }

    private readonly ISender _sender;
    
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] PostCreateDto postCreateDto, CancellationToken cancellationToken)
    {
        return await _sender.Send(new CreatePostCommand(postCreateDto), cancellationToken)
        ? Created() : BadRequest();
    }

    
    [HttpGet]
    public async Task<ActionResult<List<PostViewDto>>> FindByWord(string wordToFind, CancellationToken cancellationToken)
    {
        return await _sender.Send(new FindWordsByWordQuery(wordToFind), cancellationToken);
    }
}