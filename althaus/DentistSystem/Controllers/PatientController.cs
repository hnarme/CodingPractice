using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DentistSystem.Models;

namespace DentistSystem.Controllers;

public class PatientController : Controller
{
    private readonly ILogger<PatientController> _logger;

    public PatientController(ILogger<PatientController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index() //shows list of patients
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}