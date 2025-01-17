using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotNetCources.Models
{
	public class Coupon
	{
		[Key]
		public int Id { get; set; }

		[ForeignKey("TeacherId")]
		public int TeacherId { get; set; }
		public Teacher Teacher { get; set; }

		// TODO: Сделать Many-to-Many по этому ключу
		public ICollection<User> UsedBy { get; set; } = new List<User>();

		[Required]
		[MaxLength(50)] // Максимальная длина строки
		public string Code { get; set; }

		public int Discount { get; set; }
		public bool IsActive { get; set; }
		public DateTime date { get; set; } = DateTime.Now;

		public override string ToString()
		{
			return Code;
		}


	}
}


/*
 
 class Coupon(models.Model):
    teacher = models.ForeignKey(Teacher, on_delete=models.SET_NULL, null=True, blank=True)
    used_by = models.ManyToManyField(User, blank=True)
    code = models.CharField(max_length=50)
    discount = models.IntegerField(default=1)
    active = models.BooleanField(default=False)
    date = models.DateTimeField(default=timezone.now)   

    def __str__(self):
        return self.code
 
 */