using PersonalBlog.Entity.DTOs.Category;

namespace PersonalBlog.Service.Services.Abstractions;

public interface ICategoryService
{
    public Task<List<CategoryDto>> GetCategories();
    public Task CreateCategory(CategoryCreateDto categoryCreateDto);
    public Task<CategoryDto> GetCategoryDetail(string id);
}
