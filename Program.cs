
using dotNetCources.Models;
using dotNetCources.Services;
using Microsoft.EntityFrameworkCore;

namespace dotNetCources
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var configuration = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json", optional: true)
				.Build(); // Строит окончательную конфигурацию


			builder.Services.AddDbContext<AppContextDB>(options =>
						options.UseMySql
						(
							configuration.GetConnectionString("MySQLConnection"),
							new MySqlServerVersion(new Version(8, 4, 3))
						)
			);


			builder.Services.AddScoped<ICategoryService, CategoryService>();
			//builder.Services.AddSingleton<ILogger>();

			var app = builder.Build();


			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
