using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{
	public class Variant
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public int CourseId { get; set; }

		[ForeignKey("CourseId")]
		public Course Course { get; set; }

		[MaxLength(1000)]
		public string Title { get; set; }

		public string VariantId { get; set; } = Guid.NewGuid().ToString().Substring(0, 6);

		public DateTime Date { get; set; } = DateTime.Now;
	}
}
