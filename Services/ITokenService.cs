using dotNetCources.Models;
using System.Security.Claims;

namespace dotNetCources.Services
{
	public interface ITokenService
	{
		string GenerateAccessToken(User user);
		string GenerateRefreshToken();
		ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
	}
}
