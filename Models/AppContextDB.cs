﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dotNetCources.Models
{
	public class AppContextDB : IdentityDbContext<User>
	{
		public DbSet<Profile> Profiles { get; set; }

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
			modelBuilder.Entity<Teacher>().HasOne(t => t.Country).WithMany(c => c.Teachers); ;

			// Fluent API Country
			modelBuilder.Entity<Country>().HasKey(c => c.Id).HasName("PK_Country"); ;

			


			base.OnModelCreating(modelBuilder);
		}

	}
}
