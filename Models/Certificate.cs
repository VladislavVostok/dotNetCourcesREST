using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{
	public class Certificate
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[ForeignKey("Course")]
		public int? CourseId { get; set; }
		public Course Course { get; set; }

		[ForeignKey("User")]
		public string? UserId { get; set; }
		public User User { get; set; }

		[Required]
		[MaxLength(20)] // Указание максимальной длины
		public string CertificateId { get; set; } = GenerateShortId();

		public DateTime Date { get; set; } = DateTime.Now;



		// Генерация уникального идентификатора (аналог ShortUUIDField)
		private static string GenerateShortId()
		{
			var random = new Random();
			const string alphabet = "1234567890";
			char[] id = new char[6];
			for (int i = 0; i < id.Length; i++)
			{
				id[i] = alphabet[random.Next(alphabet.Length)];
			}
			return new string(id);
		}
	}
}
