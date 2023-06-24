using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Service.Services.Abstractions;
using PersonalBlog.Web.Models;

namespace PersonalBlog.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Index", "Article");
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Search(IFormCollection datas)
    {
        var tr = datas["searchText"].ToString();
        ViewBag.SearchText = tr;
        return View();
    }
}
