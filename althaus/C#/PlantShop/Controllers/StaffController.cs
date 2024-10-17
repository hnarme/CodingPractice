using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PlantShop.Models;

namespace PlantShop.Controllers;

public class StaffController : Controller
{
    private readonly ILogger<StaffController> _logger;

    public StaffController(ILogger<StaffController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(Staff staff)
    {
        staff.DatabaseConnection();
        return View(staff.GetStaff());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
