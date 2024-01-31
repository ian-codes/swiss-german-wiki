using MediatR;
using Sgw.Application.DTOs.Posts;

namespace Sgw.Application.Commands.Posts;

public record CreatePostCommand(PostCreateDto PostCreateDto) : IRequest<bool>;