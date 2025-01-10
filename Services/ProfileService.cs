using dotNetCources.Models;

namespace dotNetCources.Services
{
	public class ProfileService : IProfileService
	{
		private readonly AppContextDB _context;

		public ProfileService(AppContextDB context) {
			_context = context;			
		}

		public void CreateProfileForUser(User user)
		{
			var profile = new Profile
			{
				UserId = user.Id,
				FullName = user.FullName,
				Image = "default-user.jpg",
				DateCreated = DateTime.Now
			};

			profile.InitializeDefaults();
			_context.Profiles.Add(profile);
			_context.SaveChanges();
		}
	}
}
