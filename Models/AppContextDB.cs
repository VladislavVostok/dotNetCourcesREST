using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dotNetCources.Models
{
	public class AppContextDB : IdentityDbContext<User>
	{
		public DbSet<Profile> Profiles { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public DbSet<CartOrder> CartOrders { get; set; }
		public DbSet<CartOrderItem> CartOrderItems { get; set; }
		public DbSet<Coupon> Coupons { get; set; }
		public DbSet<QuestionAnswerMessage> QuestionAnswerMessages { get; set; }
		public DbSet<Variant> Variants { get; set; }
		public DbSet<VariantItem> VariantItems { get; set; }
		public DbSet<Certificate> Certificates { get; set; }
		public DbSet<CompletedLesson> CompletedLessons { get; set; }
		public DbSet<EnrolledCourse> EnrolledCourses { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Wishlist> Wishlists { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<User> Users { get; set; }


		public AppContextDB(DbContextOptions<AppContextDB> options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Fluent API Certificate
			modelBuilder.Entity<Certificate>().HasKey(c => c.CertificateId).HasName("PK_Certificate");
			modelBuilder.Entity<Certificate>()
				.HasOne(c => c.Course)
				.WithMany()
				.HasForeignKey(c => c.CourseId)
				;

			modelBuilder.Entity<Certificate>()
			  .HasOne(c => c.User)
			  .WithMany()
			  .HasForeignKey(c => c.UserId)
			 ;

			// Fluent API Profiles
			modelBuilder.Entity<User>()
				.HasOne(u => u.Profile)
				.WithOne(p => p.User)
				.HasForeignKey<Profile>(p => p.UserId)
				.OnDelete(DeleteBehavior.Cascade);

			// Fluent API Category
			modelBuilder.Entity<Category>().HasKey(c => c.Id).HasName("PK_Category");

			// Fluent API Course
			modelBuilder.Entity<Course>().HasKey(c => c.Id).HasName("PK_Course");
			modelBuilder.Entity<Course>().HasOne(c => c.Category).WithMany(c => c.Courses);
			modelBuilder.Entity<Course>().HasOne(c => c.Teacher).WithMany(t => t.Courses);

			// Fluent API Teacher
			modelBuilder.Entity<Teacher>().HasKey(t => t.Id).HasName("PK_Teacher");

			// Fluent API Cart
			modelBuilder.Entity<Cart>().HasKey(c => c.Id).HasName("PK_Cart");
			modelBuilder.Entity<Cart>().HasOne(c => c.Course).WithMany(c => c.Carts);

			// Fluent API Coupon
			modelBuilder.Entity<Coupon>().HasKey(c => c.Id).HasName("PK_Coupon");
			modelBuilder.Entity<Coupon>().HasMany(c => c.UsedBy).WithMany(u => u.Coupons).UsingEntity(j => j.ToTable("CouponUsers")); // Имя промежуточной таблицы
			modelBuilder.Entity<Coupon>()
				.HasOne(c => c.Teacher)
				.WithMany()
				.HasForeignKey(c => c.TeacherId);


			// Fluent API CompletedLesson
			modelBuilder.Entity<CompletedLesson>().HasKey(cl => cl.Id).HasName("PK_CompletedLesson"); 
			modelBuilder.Entity<CompletedLesson>()
				.HasOne(cl => cl.Course)
				.WithMany()
				.HasForeignKey(cl => cl.CourseId)
				.OnDelete(DeleteBehavior.Cascade);
			modelBuilder.Entity<CompletedLesson>()
				.HasOne(cl => cl.User)
				.WithMany()
				.HasForeignKey(cl => cl.UserId)
				.OnDelete(DeleteBehavior.SetNull);
			modelBuilder.Entity<CompletedLesson>()
				.HasOne(cl => cl.VariantItem)
				.WithMany()
				.HasForeignKey(cl => cl.VariantItemId)
				.OnDelete(DeleteBehavior.Cascade);			
			modelBuilder.Entity<CompletedLesson>()
				.HasOne(cl => cl.EnrolledCourse)
				.WithMany()
				.HasForeignKey(cl => cl.EnrolledCourseId)
				.OnDelete(DeleteBehavior.Cascade);


			// Fluent API EnrolledCourse
			modelBuilder.Entity<EnrolledCourse>().HasKey(ec => ec.EnrollmentId).HasName("PK_EnrolledCourse");

			modelBuilder.Entity<EnrolledCourse>()
				.HasOne(ec => ec.Course)
				.WithMany()
				.HasForeignKey(ec => ec.CourseId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<EnrolledCourse>()
				.HasOne(ec => ec.User)
				.WithMany()
				.HasForeignKey(ec => ec.UserId)
				.OnDelete(DeleteBehavior.SetNull);

			modelBuilder.Entity<EnrolledCourse>()
				.HasOne(ec => ec.Teacher)
				.WithMany()
				.HasForeignKey(ec => ec.TeacherId)
				.OnDelete(DeleteBehavior.SetNull);

			modelBuilder.Entity<EnrolledCourse>()
				.HasOne(ec => ec.OrderItem)
				.WithMany()
				.HasForeignKey(ec => ec.OrderItemId)
				.OnDelete(DeleteBehavior.Cascade);


			// Fluent API Review 
			modelBuilder.Entity<Review>().HasKey(r => r.Id).HasName("PK_Review");

			modelBuilder.Entity<Review>()
				.HasOne(r => r.Course)
				.WithMany()
				.HasForeignKey(r => r.CourseId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Review>()
				.HasOne(r => r.User)
				.WithMany()
				.HasForeignKey(r => r.UserId)
				.OnDelete(DeleteBehavior.SetNull);

			// Fluent API Wishlist
			modelBuilder.Entity<Wishlist>().HasKey(w => w.Id).HasName("PK_Wishlist");
			modelBuilder.Entity<Wishlist>()
				.HasOne(w => w.Course)
				.WithMany()
				.HasForeignKey(w => w.CourseId)
				.OnDelete(DeleteBehavior.Cascade);
			modelBuilder.Entity<Wishlist>()
				.HasOne(w => w.User)
				.WithMany()
				.HasForeignKey(w => w.UserId)
				.OnDelete(DeleteBehavior.SetNull);

			// Fluent API Country
			modelBuilder.Entity<Country>().HasKey(c => c.Id).HasName("PK_Country");

			base.OnModelCreating(modelBuilder);
		}

	}
}
