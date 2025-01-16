using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{
	public class VariantItem
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public int VariantId { get; set; }

		[ForeignKey("VariantId")]
		public Variant Variant { get; set; }

		[MaxLength(1000)]
		public string Title { get; set; }

		public string Description { get; set; }

		public string File { get; set; }

		public TimeSpan? Duration { get; set; }

		public string ContentDuration { get; set; }

		public bool Preview { get; set; } = false;

		public string VariantItemId { get; set; } = Guid.NewGuid().ToString().Substring(0, 6);

		public DateTime Date { get; set; } = DateTime.Now;
	}
}
