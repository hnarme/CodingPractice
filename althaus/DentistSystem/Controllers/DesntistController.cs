using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DentistSystem.Models;

namespace DentistSystem.Controllers;

public class DesntistController : Controller
{
    private readonly ILogger<DesntistController> _logger;

    public DesntistController(ILogger<DesntistController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ViewAppointment()
    {
        return View();
    }

    public IActionResult ViewPatient()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}