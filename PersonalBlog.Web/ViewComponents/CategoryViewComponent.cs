using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Service.Services.Abstractions;

namespace PersonalBlog.Web.ViewComponents;

public class CategoryViewComponent : ViewComponent
{
    private readonly ICategoryService _categoryService;
    public CategoryViewComponent(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return await Task.Run(async () => View(await _categoryService.GetCategories()));
    }
}
