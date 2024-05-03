using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using WorigoApp.Application.Features.Auth.Commands.Login;
using WorigoApp.Application.Features.Auth.Dtos;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Interfaces.Auth.Jwt.Tokens
{
    public interface ITokenService
    {
        Task<JwtSecurityToken> CreateToken(Users user, IList<string> roles);
        string GenerateRefreshToken();
        ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token);
        public Task<LoginCommandResponse> GenerateToken(GenerateTokenRequest roleRequest);
    }
}
