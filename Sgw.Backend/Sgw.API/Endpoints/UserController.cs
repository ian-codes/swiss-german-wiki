using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sgw.Application.Commands.Users;
using Sgw.Application.DTOs.Posts;
using Sgw.Application.DTOs.Users;
using Sgw.Application.Queries;

namespace Sgw.API.Endpoints;

[ApiController]
[Route("[controller]")]
public sealed class UserController : ControllerBase
{
    public UserController(ISender sender)
    {
        _sender = sender;
    }

    private readonly ISender _sender;
    
    
    [HttpPost]
    public async Task<IActionResult> SignUp([FromBody] UserCreateDto userCreateDto, CancellationToken cancellationToken)
    {
        return await _sender.Send(new SignUpUserCommand(userCreateDto), cancellationToken)
            ? Created() : BadRequest();
    }

    
    [HttpGet]
    public async Task<ActionResult<List<PostViewDto>>> FindByWord(string wordToFind, CancellationToken cancellationToken)
    {
        return await _sender.Send(new FindWordsByWordQuery(wordToFind), cancellationToken);
    }
}