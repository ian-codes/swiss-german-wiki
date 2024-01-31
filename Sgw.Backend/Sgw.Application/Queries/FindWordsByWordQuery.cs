using MediatR;
using Sgw.Application.DTOs.Posts;

namespace Sgw.Application.Queries;

public record FindWordsByWordQuery(string word) : IRequest<List<PostViewDto>>;