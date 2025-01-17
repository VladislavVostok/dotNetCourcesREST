using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{
	public class CompletedLesson
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[ForeignKey("EnrolledCourse")]
		public string EnrolledCourseId { get; set; }
		public EnrolledCourse EnrolledCourse { get; set; }

		[ForeignKey("User")]
		public string? UserId { get; set; }
		public User User { get; set; }

		[ForeignKey("Course")]
		public int CourseId { get; set; }
		public Course Course { get; set; }

		[ForeignKey("VariantItem")]
		public int? VariantItemId { get; set; }
		public VariantItem VariantItem { get; set; }


		public string LessonTitle { get; set; }

		public DateTime CompletedAt { get; set; } = DateTime.Now;


	}

}
