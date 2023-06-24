using Microsoft.AspNetCore.Mvc;

namespace PersonalBlog.Web.Controllers;

public class ProfileController : Controller
{
    private readonly ILogger<ProfileController> _logger;

    public ProfileController(ILogger<ProfileController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Edit()
    {
        return View();
    }
}
