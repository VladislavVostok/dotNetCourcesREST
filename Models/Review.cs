using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{
	public class Review
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
		[Range(1, 5)]
		public int Rating { get; set; }

		public string ReviewText { get; set; }

		public bool Active { get; set; } = true;

		public DateTime CreatedAt { get; set; } = DateTime.Now;


	}
}
