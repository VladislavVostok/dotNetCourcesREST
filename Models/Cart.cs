using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{
	public class Cart
	{
		[Key]
		public int Id { get; set; }

		[ForeignKey("Course")]
		public int CourseId { get; set; }
		public Course Course { get; set; }

		[ForeignKey("User")]
		public string UserId { get; set; }
		public User User { get; set; }

		[Column(TypeName = "decimal(12, 2)")]
		public decimal Price { get; set; } = 0.00M;

		[Column(TypeName = "decimal(12, 2)")]
		public decimal TaxFee { get; set; } = 0.00M;

		[Column(TypeName = "decimal(12, 2)")]
		public decimal Total { get; set; } = 0.00M;

		[MaxLength(100)]
		public string Country { get; set; }

		[MaxLength(20)]
		public string CartId { get; set; } = GenerateShortUUID();

		public DateTime Date { get; set; } = DateTime.UtcNow;

		public virtual ICollection<Course> Courses { get; set; }
		private static string GenerateShortUUID()
		{
			return Guid.NewGuid().ToString("N").Substring(0, 6);
		}
	}
}
