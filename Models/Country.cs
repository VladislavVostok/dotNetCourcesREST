using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{
	public class Country
	{
		[Key]
		public int Id { get; set; } // Первичный ключ

		[Required]
		[MaxLength(100)] // Указывает максимальную длину строки
		public string Name { get; set; }

		[Required]
		[Range(0, 100)] // Указывает допустимый диапазон для налоговой ставки
		public int TaxRate { get; set; } = 5; // Значение по умолчанию

		[Required]
		public bool Active { get; set; } = true; // Значение по умолчанию

		public override string ToString()
		{
			return Name; // Аналог метода `__str__` в Django
		}
	}
}