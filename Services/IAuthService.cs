using dotNetCources.DTO.Auth;
using dotNetCources.DTO.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotNetCources.Services
{
	public interface IAuthService
	{
		public Task<Dictionary<string, string>> Login(LoginDto loginDto);
		public Task<Dictionary<string, object>> Register(RegisterDto registerDto);
		public Task<Dictionary<string, string>> SendPasswordResetEmail(string email);
		public Task<Dictionary<string, string>> ResetPassword(PasswordResetDto resetDto);
		public Task<Dictionary<string, string>> ChangePassword( ChangePasswordDto changeDto);
	}
}
