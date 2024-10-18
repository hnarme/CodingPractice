using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PlantShop.Models;

namespace PlantShop.Controllers;

public class StaffController : Controller
{
    private readonly ILogger<StaffController> _logger;
    private readonly IConfiguration _configuration;
    //public Staff staff = new Staff();

    public StaffController(ILogger<StaffController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        //staff.DatabaseConnection();
        //return View(staff.GetStaff());
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        return View(Database.Instance.GetAllStaff());
    }

    public ViewResult Display(int id)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        Staff idStaff = Database.Instance.GetAllStaff().FirstOrDefault(staff => staff.Staff_Id == id);
        return View(idStaff);
    }

    public ViewResult Edit(int id)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        Staff editStaff = Database.Instance.GetAllStaff().FirstOrDefault(staff => staff.Staff_Id == id);
        return View(editStaff);
    }

    public ViewResult Delete(int id)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        Staff deleteStaff = Database.Instance.GetAllStaff().FirstOrDefault(staff => staff.Staff_Id == id);
        return View(deleteStaff);
    }

    public ActionResult Create(Staff staff)
    {
        Database.Instance.AddStaff(staff);
        staff.Email = staff.Forename + staff.Surname + "@greenplant.com";
        return View(staff);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}