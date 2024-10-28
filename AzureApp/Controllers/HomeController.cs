using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AzureApp.Models;

namespace AzureApp.Controllers;

public class HomeController(ILogger<HomeController> logger,
                            IConfiguration configuration) : Controller
{
    public IActionResult Index()
    {
        ViewBag.Greetings = configuration["Greetings"]!;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
