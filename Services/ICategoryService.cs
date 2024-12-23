using dotNetCources.Models;

namespace dotNetCources.Services
{
	public interface ICategoryService
	{
		Task GetCategoriesAsync();
		Task GetCategoriByIdAsync(int id);
		Task UpdateCategoryByIdAsync(int id, Category category);
		Task<Category> AddCategoryAsync(Category category);
		Task DeleteCategoryByIdAsync(int id);
	}
}
