using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{
	public class CartOrder
	{
		[Key]
		public int Id { get; set; }

		[ForeignKey("User")]
		public string StudentId { get; set; }
		public User Student { get; set; }

		public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();

		[Column(TypeName = "decimal(12, 2)")]
		public decimal SubTotal { get; set; } = 0.00M;

		[Column(TypeName = "decimal(12, 2)")]
		public decimal TaxFee { get; set; } = 0.00M;

		[Column(TypeName = "decimal(12, 2)")]
		public decimal Total { get; set; } = 0.00M;

		[Column(TypeName = "decimal(12, 2)")]
		public decimal InitialTotal { get; set; } = 0.00M;

		[Column(TypeName = "decimal(12, 2)")]
		public decimal Saved { get; set; } = 0.00M;

		[MaxLength(100)]
		public string PaymentStatus { get; set; } = "Processing";

		[MaxLength(100)]
		public string FullName { get; set; }
		[MaxLength(100)]
		public string Email { get; set; }

		[MaxLength(100)]
		public string Country { get; set; }

		public ICollection<Coupon> Coupons { get; set; } = new List<Coupon>();

		[MaxLength(1000)]
		public string StripeSessionId { get; set; }

		[MaxLength(20)]
		public string Oid { get; set; } = GenerateShortUUID();

		public DateTime Date { get; set; } = DateTime.UtcNow;

		public ICollection<CartOrderItem> OrderItems { get; set; }

		private static string GenerateShortUUID()
		{
			return Guid.NewGuid().ToString("N").Substring(0, 6);
		}
	}
}
