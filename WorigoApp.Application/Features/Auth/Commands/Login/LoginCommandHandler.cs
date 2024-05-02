using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Auth.Rules;
using WorigoApp.Application.Helpers;
using WorigoApp.Application.Interfaces.Auth.Jwt.Tokens;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Auth.Commands.Login
{
    public class LoginCommandHandler : BaseHandler, IRequestHandler<LoginCommandRequest, Response<LoginCommandResponse>>
    {
        private readonly AuthRule _authRule;
        private readonly ITokenService _tokenService;

        public LoginCommandHandler(ITokenService tokenService, AuthRule authRule, IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
            this._authRule = authRule;
            this._tokenService = tokenService;
        }

        public async Task<Response<LoginCommandResponse>> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
        {
            var user = await unitOfWork.GetReadRepository<Users>().GetAsync(x => x.Email == request.Email && x.Password == PasswordHash.HashPassword(request.Password) && !x.IsDeleted,
                y => y.Include(x => x.Role));

            await _authRule.EmailOrPasswordShouldNotBeInvalid(user);

            var token = await _tokenService.GenerateToken(new GenerateTokenRequest(user.Id, user.Email, user.Role.Name));

            var map = mapper.Map<LoginCommandResponse, GenerateTokenResponse>(token);

            return new Response<LoginCommandResponse>().Success(map);
        }
    }
}
