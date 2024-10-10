using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DentistSystem.Models;

namespace DentistSystem.Controllers;

public class ReceptionistController : Controller
{
    private readonly ILogger<ReceptionistController> _logger;

    public ReceptionistController(ILogger<ReceptionistController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CreateAppointment()
    {
        return View();
    }

    public IActionResult EditAppointment()
    {
        return View();
    }

    public IActionResult RegisterPatient()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}