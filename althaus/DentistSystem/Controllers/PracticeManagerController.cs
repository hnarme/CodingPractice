using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DentistSystem.Models;

namespace DentistSystem.Controllers;

public class PracticeManagerController : Controller
{
    private readonly ILogger<PracticeManagerController> _logger;

    public PracticeManagerController(ILogger<PracticeManagerController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CreateDentist()
    {
        return View();
    }

    public IActionResult EditDentist()
    {
        return View();
    }

    public IActionResult DeleteDentist()
    {
        return View();
    }

    public IActionResult CreateReceptionist()
    {
        return View();
    }

    public IActionResult EditReceptionist()
    {
        return View();
    }

    public IActionResult DeleteReceptionist()
    {
        return View();
    }

    public IActionResult EditStaffPermission()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}