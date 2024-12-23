using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{
	public class Category
	{
		public int Id { get; set; }

		[MaxLength(32)]
		public string Title { get; set; }
		public string? ImagePath { get; set; }
		public bool Active { get; set; }
		[MaxLength(32)]
		public string Slug { get; set; }
		public List<Course>? Courses { get; set; } = new List<Course>();
	}

	public class Country
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Teacher>? Teachers { get; set; } = new List<Teacher>();
	}

	public class Teacher
	{
		public int Id { get; set; }
		// TODO: Сделать связь один к одному с IdentityFramework там будут Пользователи
		public string? ImagePath { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string? MiddleName { get; set; }
		public string? Bio { get; set; }
		public int CountryId { get; set; }
		public Country? Country { get; set; }
		public List<Course>? Courses { get; set; } = new List<Course>();
	}

	public class Course
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public Category? Category { get; set; }
		public int TeacherId { get; set; }
		public Teacher? Teacher { get; set; }
		public string? ImagePath { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public bool PlatformStatus { get; set; }
		public bool TeacherCourceStatus { get; set; }
		[MaxLength(32)]
		public string Slug { get; set; }
		public DateTime? DateAt { get; set; } = DateTime.Now;
	}
}
