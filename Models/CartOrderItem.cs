using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{
	public class CartOrderItem
	{
		[Key]
		public int Id { get; set; }

		[ForeignKey("CartOrder")]
		public int OrderId { get; set; }
		public CartOrder Order { get; set; }

		[ForeignKey("Course")]
		public int CourseId { get; set; }
		public Course Course { get; set; }

		[ForeignKey("Teacher")]
		public int TeacherId { get; set; }
		public Teacher Teacher { get; set; }

		[Column(TypeName = "decimal(12, 2)")]
		public decimal Price { get; set; } = 0.00M;

		[Column(TypeName = "decimal(12, 2)")]
		public decimal TaxFee { get; set; } = 0.00M;

		[Column(TypeName = "decimal(12, 2)")]
		public decimal Total { get; set; } = 0.00M;

		[Column(TypeName = "decimal(12, 2)")]
		public decimal InitialTotal { get; set; } = 0.00M;

		[Column(TypeName = "decimal(12, 2)")]
		public decimal Saved { get; set; } = 0.00M;

		public ICollection<Coupon> Coupons { get; set; } = new List<Coupon>();

		public bool AppliedCoupon { get; set; } = false;

		[MaxLength(20)]
		public string Oid { get; set; } = GenerateShortUUID();

		public DateTime Date { get; set; } = DateTime.UtcNow;

		private static string GenerateShortUUID()
		{
			return Guid.NewGuid().ToString("N").Substring(0, 6);
		}
	}
}
