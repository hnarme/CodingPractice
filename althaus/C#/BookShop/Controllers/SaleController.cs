using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookShop.Models;

namespace BookShop.Controllers;

public class SaleController : Controller
{
    private readonly ILogger<SaleController> _logger;

    public SaleController(ILogger<SaleController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
