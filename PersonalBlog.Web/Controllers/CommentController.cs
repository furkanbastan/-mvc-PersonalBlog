using Microsoft.AspNetCore.Mvc;

namespace PersonalBlog.Web.Controllers;

public class CommentController : Controller
{
    private readonly ILogger<CommentController> _logger;
    public CommentController(ILogger<CommentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Create()
    {
        return View();
    }
    public IActionResult Delete()
    {
        return View();
    }
}
