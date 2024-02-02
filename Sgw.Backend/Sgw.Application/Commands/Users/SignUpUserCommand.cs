using MediatR;
using Sgw.Application.DTOs.Users;

namespace Sgw.Application.Commands.Users;

public record SignUpUserCommand(UserCreateDto userCreateDto) : IRequest<bool>;
