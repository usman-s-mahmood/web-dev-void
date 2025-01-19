using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using assignment_3.Models;

namespace assignment_3.Controllers;

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

    public IActionResult Not_Found() {
        return View();
    }

    public IActionResult Blog_Single() {
        return View();
    }

    public IActionResult Contact() {
        return View();
    }

    public IActionResult Portfolio_Detail() {
        return View();
    }

    public IActionResult NotFound() {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
