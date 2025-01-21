using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{

	public class EnrolledCourse
	{
		[Key]
		public string Id { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; } // Nullable UserId
        public User User { get; set; }
        [Required]
		[ForeignKey("Course")]
		public int CourseId { get; set; }
		public Course Course { get; set; }
		[ForeignKey("Teacher")]
		public int TeacherId { get; set; }	
		public Teacher Teacher { get; set; }
		[ForeignKey("CartOrderItem")]
		public int OrderItemId {  get; set; }
		public CartOrderItem OrderItem { set; get; }
		public string EnrollmentId { get; set; } = Guid.NewGuid().ToString();
		public DateTime Date { get; set; } = DateTime.Now;



		public ICollection<CompletedLesson> CompletedLessons { get; set; }
	}
}
