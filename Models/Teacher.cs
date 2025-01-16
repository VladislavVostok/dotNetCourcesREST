using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace dotNetCources.Models
{
	public class Teacher
	{
		[Key]
		public int Id { get; set; }

		//[Required]
		//public int UserId { get; set; }

		//[ForeignKey("UserId")]
		//public User User { get; set; }

		[MaxLength(100)]
		public string FullName { get; set; }

		public string Image { get; set; } = "default.jpg";

		[MaxLength(100)]
		public string Bio { get; set; }

		public string VK { get; set; }

		public string OK { get; set; }

		public string GitHub { get; set; }

		public string LinkedIn { get; set; }

		public string About { get; set; }

		public string Country { get; set; }

		public virtual ICollection<Course> Courses { get; set; }

		public override string ToString()
		{
			return FullName;
		}
	}
}
