using dotNetCources.States;

namespace dotNetCources.DTO.Courses
{
	public class CourceCreateRequestDTO
	{
		public int? CategoryId { get; set; }

		public int TeacherId { get; set; }

		public string File { get; set; }

		public string Image { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }

		public Language Language { get; set; }

		public Level Level { get; set; }

		public TeacherStatus TeacherCourseStatus { get; set; }

	}
}
