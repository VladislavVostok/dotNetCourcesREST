using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{
	public class Wishlist
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[ForeignKey("User")]
		public string UserId { get; set; }
		public User User { get; set; }

		[Required]
		[ForeignKey("Course")]
		public int CourseId { get; set; }
		public Course Course { get; set; }
	}
}
