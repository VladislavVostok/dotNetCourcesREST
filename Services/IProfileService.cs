using dotNetCources.Models;

namespace dotNetCources.Services
{
	public interface IProfileService
	{
		void CreateProfileForUser(User user);
	}
}
