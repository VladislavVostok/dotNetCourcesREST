using Microsoft.EntityFrameworkCore;

namespace dotNetCources.Models
{
	public class AppContextDB : DbContext
	{
		public DbSet<Course> Courses { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Country> Countries { get; set; }

		public AppContextDB(DbContextOptions<AppContextDB> options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasKey(c => c.Id).HasName("PK_Category");
			

			modelBuilder.Entity<Course>().HasKey(c => c.Id).HasName("PK_Course");
			modelBuilder.Entity<Course>().HasOne(c => c.Category).WithMany(c => c.Courses);
			modelBuilder.Entity<Course>().HasOne(c => c.Teacher).WithMany(t => t.Courses);


			modelBuilder.Entity<Teacher>().HasKey(t => t.Id).HasName("PK_Teacher");
			modelBuilder.Entity<Teacher>().HasOne(t => t.Country).WithMany(c => c.Teachers); ;


			modelBuilder.Entity<Country>().HasKey(c => c.Id).HasName("PK_Country"); ;


			base.OnModelCreating(modelBuilder);
		}

	}
}
