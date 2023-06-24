using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Entity.DTOs.Article;
using PersonalBlog.Service.Services.Abstractions;

namespace PersonalBlog.Web.Controllers;

public class ArticleController : Controller
{
    private readonly IArticleService _articleService;
    public ArticleController(IArticleService articleService)
    {
        _articleService = articleService;
    }
    public async Task<IActionResult> Index()
    {
        return View(await _articleService.GetArticlesWithPagination());
    }
    public async Task<IActionResult> IndexArchive()
    {
        return View(await _articleService.GetArticlesArchiveWithPagination());
    }
    public async Task<IActionResult> IndexByCategory(string id)
    {
        var articles = await _articleService.GetArticlesByCategory(Guid.Parse(id));
        return View(articles);
    }
    public async Task<IActionResult> Detail(string id)
    {
        return View(await _articleService.GetArticleDetailWithComments(Guid.Parse(id)));
    }
    public async Task<IActionResult> Edit(string id)
    {
        return View(await _articleService.GetArticleEditDto(Guid.Parse(id)));
    }
    [HttpPost]
    public async Task<IActionResult> Edit(ArticleEditDto articleEditDto)
    {
        await _articleService.EditArticle(articleEditDto);
        return RedirectToAction("Index");
    }
    [HttpPost]
    public async Task<IActionResult> Delete(string id)
    {
        await _articleService.DeleteArticle(Guid.Parse(id));
        return RedirectToAction("Index");
    }
    public async Task<IActionResult> Create()
    {
        return View(await _articleService.GetArticleCreateDto());
    }
    [HttpPost]
    public async Task<IActionResult> Create(ArticleCreateDto articleCreateDto)
    {
        await _articleService.CreateArticle(articleCreateDto);
        return RedirectToAction("Index");
    }
}
