using dotNetCources.States;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotNetCources.Models
{

	public class Course
	{
		[Key]
		public int Id { get; set; }

		public int? CategoryId { get; set; }

		[ForeignKey("CategoryId")]
		public Category Category { get; set; }

		[Required]
		public int TeacherId { get; set; }

		[ForeignKey("TeacherId")]
		public Teacher Teacher { get; set; }

		public string File { get; set; }

		public string Image { get; set; }

		[MaxLength(200)]
		public string Title { get; set; }

		public string Description { get; set; }

		[Column(TypeName = "decimal(12,2)")]
		public decimal Price { get; set; } = 0.00m;

		public Language Language { get; set; } = Language.Russian;

		public Level Level { get; set; } = Level.Beginner;

		public PlatformStatus PlatformStatus { get; set; } = PlatformStatus.Draft;

		public TeacherStatus TeacherCourseStatus { get; set; } = TeacherStatus.Draft;

		public bool Featured { get; set; } = false;

		[Required]
		public string CourseId { get; set; } = Guid.NewGuid().ToString().Substring(0, 6);

		public string Slug { get; set; }

		public DateTime Date { get; set; } = DateTime.Now;



		public virtual ICollection<Cart> Carts { get; set; }
	}
}
