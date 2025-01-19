using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WAD_ASM_3.Models;

namespace WAD_ASM_3.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About() {
        return View();
    }

    public IActionResult Contact() {
        return View();
    }

    public IActionResult Portfolio() {
        return View();
    }

    public IActionResult Team() {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
