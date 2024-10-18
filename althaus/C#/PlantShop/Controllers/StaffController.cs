using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PlantShop.Models;

namespace PlantShop.Controllers;

public class StaffController : Controller
{
    private readonly ILogger<StaffController> _logger;
    public Staff staff = new Staff();

    public StaffController(ILogger<StaffController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        staff.DatabaseConnection();
        return View(staff.GetStaff());
    }

    public ViewResult Display(int id)
    {
        Staff idStaff = staff.GetStaff().FirstOrDefault(staff => staff.Staff_Id == id);
        return View(idStaff);
    }

    public ViewResult Edit(int id)
    {
        Staff editStaff = staff.GetStaff().FirstOrDefault(staff => staff.Staff_Id == id);
        return View(editStaff);
    }

    public ViewResult Delete(int id)
    {
        Staff deleteStaff = staff.GetStaff().FirstOrDefault(staff => staff.Staff_Id == id);
        return View(deleteStaff);
    }

    public ActionResult Create(Staff staff)
    {
        return View(staff);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}
