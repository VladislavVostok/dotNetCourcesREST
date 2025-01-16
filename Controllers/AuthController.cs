using dotNetCources.Models;
using dotNetCources.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using dotNetCources.DTO.Authorization;
namespace dotNetCources.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly UserManager<User> _userManager;
		private readonly ITokenService _tokenService;
		private readonly IProfileService _profileService;
		private readonly IEmailService _emailService;

		public AuthController(	UserManager<User> userManager, 
								ITokenService tokenService, 
								IEmailService emailService){
			_userManager = userManager;
			_tokenService = tokenService;
			_emailService = emailService;
		}

		[HttpPost("login")]
		[AllowAnonymous]
		public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
		{
			var user = await _userManager.FindByEmailAsync(loginDto.Email);
			if (user != null && await _userManager.CheckPasswordAsync(user, loginDto.Password))
			{
				var accessToken = _tokenService.GenerateAccessToken(user);
				var refreshToken = _tokenService.GenerateRefreshToken();

				// Сохраните refreshToken в базе данных или другой системе
				user.RefreshToken = refreshToken;
				await _userManager.UpdateAsync(user);

				return Ok(
					new
						{
							AccessToken = accessToken,
							RefreshToken = refreshToken
						}
					);
			}

			return Unauthorized(new { message = "Invalid credentials" });
		}

		[HttpPost("register")]
		[AllowAnonymous]
		public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
		{
			User user = new User
			{
				Email = registerDto.Email,
				UserName = registerDto.UserName,
				FullName = registerDto.FullName
			};

			var result = await _userManager.CreateAsync(user, registerDto.Password);

			if (result.Succeeded)
			{
				//_profileService.CreateProfileForUser(user);
			
				return Ok(new { message = "User registered successfully" });
			}

			return BadRequest(result.Errors);
		}

		[HttpGet("password-reset-email/{email}")]
		[AllowAnonymous]
		public async Task<IActionResult> SendPasswordResetEmail(string email)
		{
			var user = await _userManager.FindByEmailAsync(email);
			if (user != null)
			{
				user.OTP = GenerateRandomOtp(7);
				user.RefreshToken = _tokenService.GenerateRefreshToken(); // Simplified refresh token generation
				await _userManager.UpdateAsync(user);

				var link = $"http://localhost:5173/password-reset?otp={user.OTP}&uuid={user.Id}&refresh_token={user.RefreshToken}";
				// TODO: Configure Email Sending

				await _emailService.SendEmailAsync(user.Email, "Восстановление пароля", link);
				Console.WriteLine($"Reset Link: {link}");
				return Ok(new { message = "If the email exists, a reset link was sent." });
			}

			return BadRequest(new { message = "Такого email не существует!" });
		}

		private string GenerateRandomOtp(int length)
		{
			var random = new Random();
			return new string(Enumerable.Range(0, length).Select(_ => random.Next(0, 10).ToString()[0]).ToArray());
		}

		[HttpGet("password-reset")]
		[AllowAnonymous]
		public async Task<IActionResult> ResetPassword([FromQuery] PasswordResetDto resetDto)
		{
			var user = await _userManager.FindByIdAsync(resetDto.Uuid);
			if (user != null && user.OTP == resetDto.OTP)
			{
				var result = await _userManager.RemovePasswordAsync(user);
				if (result.Succeeded)
				{
					await _userManager.AddPasswordAsync(user, resetDto.NewPassword);
					user.OTP = null; // Clear the OTP
					await _userManager.UpdateAsync(user);
					return Ok(new { message = "Password changed successfully" });
				}
			}

			return NotFound(new { message = "Invalid OTP or user not found" });
		}


		[HttpPost("change-password")]
		[Authorize]
		public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto changeDto)
		{
			var user = await _userManager.FindByIdAsync(changeDto.UserId);
			if (user != null)
			{
				var result = await _userManager.ChangePasswordAsync(user, changeDto.OldPassword, changeDto.NewPassword);
				if (result.Succeeded)
				{
					return Ok(new { message = "Password changed successfully", icon = "success" });
				}

				return BadRequest(new { message = "Old password is incorrect", icon = "warning" });
			}

			return NotFound(new { message = "User does not exist", icon = "error" });
		}


	}
}

