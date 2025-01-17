using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace dotNetCources.Models
{
	public class User : IdentityUser
	{ 
		[Required]
		[MaxLength(100)]
		public override string UserName { get; set; }

		[Required]
		[MaxLength(100)]
		public override string Email { get; set; }

		[MaxLength(100)]
		public string FullName { get; set; }

		[MaxLength(100)]
		public string? OTP { get; set; }

		[MaxLength(1000)]
		public string? RefreshToken { get; set; }

		public Profile Profile { get; set; }

		public ICollection<Coupon> Coupons { get; set; } = new List<Coupon>();
		public ICollection<EnrolledCourse> EnrolledCourses { get; set; }
		public ICollection<Review> Reviews { get; set; }
		public ICollection<CompletedLesson> CompletedLessons { get; set; }
		public ICollection<QuestionAnswer> QuestionAnswers { get; set; }
		public ICollection<Teacher> Teachers { get; set; }
		public ICollection<Wishlist> Wishlists { get; set; }


		public override string ToString()
		{
			return Email;
		}

		public void InitializeDefaults()
		{
			var emailUsername = Email.Split('@')[0];

			if (string.IsNullOrEmpty(FullName))
				FullName = emailUsername;

			if (string.IsNullOrEmpty(UserName))
				UserName = emailUsername;
		}

	}
}
