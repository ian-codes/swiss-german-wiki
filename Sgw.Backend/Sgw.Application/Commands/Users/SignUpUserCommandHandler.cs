using MediatR;
using Sgw.Application.DTOs.Users;
using Sgw.Application.Interfaces;
using Sgw.Domain.Interfaces;
using Sgw.Domain.User;

namespace Sgw.Application.Commands.Users;

public sealed class SignUpUserCommandHandler : IRequestHandler<SignUpUserCommand, bool>
{
    public SignUpUserCommandHandler(IUserRepository userRepository
        , IPostRepository postRepository
        , IUserAuthService userAuthService)
    {
        _userRepository = userRepository;
        _postRepository = postRepository;
        _userAuthService = userAuthService;
    }
    
    private readonly IUserRepository _userRepository;
    private readonly IPostRepository _postRepository;
    private readonly IUserAuthService _userAuthService;
    
    
    public async Task<bool> Handle(SignUpUserCommand request, CancellationToken cancellationToken)
    {
        var userDto = request.userCreateDto;
        
        if (!_userAuthService.ValidateUserData(userDto))
            return false;

        var hashedPassword = _userAuthService.HashPassword(userDto.Password);
        var userModel = new UserModel(Guid.NewGuid(), userDto.Username);

        return await _userRepository.CreateUser(userModel, hashedPassword);
    }
}