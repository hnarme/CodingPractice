using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PlantShop.Models;

namespace PlantShop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;
    public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;

    }

    public IActionResult Index(Staff staff, string email, string password)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        Staff emailStaff = Database.Instance.GetAllStaff().FirstOrDefault(staff => staff.Email == email);
        Staff passwordStaff = Database.Instance.GetAllStaff().FirstOrDefault(staff => staff.Password == password);

        if (staff.Email != email && staff.Password != password)
        {
            return View(Error());
        }
        return View(staff);
    }

    public IActionResult AccountType(Staff staff)
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
