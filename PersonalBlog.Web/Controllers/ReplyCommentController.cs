using Microsoft.AspNetCore.Mvc;

namespace PersonalBlog.Web.Controllers;

public class ReplyCommentController : Controller
{
    private readonly ILogger<ReplyCommentController> _logger;
    public ReplyCommentController(ILogger<ReplyCommentController> logger)
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
