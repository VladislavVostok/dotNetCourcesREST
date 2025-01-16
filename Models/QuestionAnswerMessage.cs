using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{
	public class QuestionAnswerMessage
	{
		[Key]
		public int Id { get; set; }

		public int CourseId { get; set; }

		[ForeignKey("CourseId")]
		public Course Course { get; set; }

		public int QuestionId { get; set; }

		[ForeignKey("QuestionId")]
		public QuestionAnswer Question { get; set; }

		//public int? UserId { get; set; }

		//[ForeignKey("UserId")]
		//public User User { get; set; }

		public string Message { get; set; }

		public string QAMId { get; set; } = Guid.NewGuid().ToString().Substring(0, 6);

		public DateTime Date { get; set; } = DateTime.Now;
	}
}

