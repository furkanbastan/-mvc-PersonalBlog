using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Entity.DTOs.Category;
using PersonalBlog.Service.Services.Abstractions;

namespace PersonalBlog.Web.Controllers;

public class CategoryController : Controller
{
    private readonly ICategoryService _categoryService;
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _categoryService.GetCategories());
    }
    public IActionResult Edit()
    {
        return View();
    }
    public IActionResult Delete()
    {
        return View();
    }
    public IActionResult Create()
    {
        return View(new CategoryCreateDto());
    }
    [HttpPost]
    public async Task<IActionResult> Create(CategoryCreateDto categoryCreateDto)
    {
        await _categoryService.CreateCategory(categoryCreateDto);
        return RedirectToAction("Index");
    }
}
