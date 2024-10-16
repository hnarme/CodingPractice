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

    public IActionResult Index(Staff allStaff)
    {
        allStaff.Staff_Id = 1;
        allStaff.Forename = "John";
        allStaff.Surname = "Doe";
        allStaff.DateOfBirth = new DateOnly(1997, 5, 31);
        allStaff.Email = "johndoe@greenplant.com";
        return View(allStaff);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
