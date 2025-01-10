using Microsoft.AspNetCore.Identity;
using dotNetCources.Models;
using dotNetCources.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;

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

			// Настраиваем CORS (если требуется, например, для фронтенда)
			builder.Services.AddCors(options =>
			{
				options.AddPolicy("AllowAll", policy =>
				{
					policy.AllowAnyOrigin()
						  .AllowAnyMethod()
						  .AllowAnyHeader();
				});
			});

			// Добавляем Identity (если используется)
			builder.Services.AddIdentity<User, IdentityRole>(options =>
			{
				options.Password.RequireNonAlphanumeric = false;
				options.Password.RequiredLength = 6;
				options.Password.RequireUppercase = false;
			})
			.AddEntityFrameworkStores<AppContextDB>();

			var configuration = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json", optional: true)
				.Build(); // Строит окончательную конфигурацию


			// Добавляем JWT аутентификацию
			builder.Services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddJwtBearer(options =>
			{
				options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
				{
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ValidIssuer = configuration["Jwt:Issuer"],
					ValidAudience = configuration["Jwt:Audience"],
					IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(configuration["Jwt:Key"]))
				};
			});


			builder.Services.AddDbContext<AppContextDB>(options =>
						options.UseMySql
						(
							configuration.GetConnectionString("MySQLConnection"),
							new MySqlServerVersion(new Version(8, 4, 3))
						)
			);



			builder.Services.AddScoped<IProfileService, ProfileService>();
			builder.Services.AddScoped<ITokenService, TokenService>();
			builder.Services.AddScoped<ICategoryService, CategoryService>();



			var app = builder.Build();


			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthentication(); // Добавляем аутентификацию
			app.UseAuthorization();  // Добавляем авторизацию

			app.UseCors("AllowAll");

			app.MapControllers();

			app.Run();
		}
	}
}
