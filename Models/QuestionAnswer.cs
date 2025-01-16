using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{
	public class QuestionAnswer
	{
		[Key]
		public int Id { get; set; }

		public int CourseId { get; set; }

		[ForeignKey("CourseId")]
		public Course Course { get; set; }

		//public int? UserId { get; set; }

		//[ForeignKey("UserId")]
		//public User User { get; set; }

		[MaxLength(1000)]
		public string Title { get; set; }

		public string QAId { get; set; } = Guid.NewGuid().ToString().Substring(0, 6);

		public DateTime Date { get; set; } = DateTime.Now;
	}
}
