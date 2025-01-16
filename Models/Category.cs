using System.ComponentModel.DataAnnotations;

namespace dotNetCources.Models
{
	public class Category
	{

		public int Id { get; set; }

		[MaxLength(100)]
		public string Title { get; set; }

		public string Image { get; set; } = "category.jpg";

		public bool Active { get; set; } = true;

		public string Slug { get; set; }

		public virtual ICollection<Course> Courses { get; set; }
	}
}
