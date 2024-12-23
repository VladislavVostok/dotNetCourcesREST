using dotNetCources.Models;

namespace dotNetCources.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly AppContextDB _db;
		//private readonly ILogger _logger;

		public CategoryService(AppContextDB appContextDB)
		{
			_db = appContextDB;
			//_logger = logger;
		}

		async Task<Category> ICategoryService.AddCategoryAsync(Category category)
		{
			_db.Categories.Add(category);
			await _db.SaveChangesAsync();

			return category;
		}

		Task ICategoryService.DeleteCategoryByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		Task ICategoryService.GetCategoriByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		Task ICategoryService.GetCategoriesAsync()
		{
			throw new NotImplementedException();
		}

		Task ICategoryService.UpdateCategoryByIdAsync(int id, Category category)
		{
			throw new NotImplementedException();
		}
	}
}
