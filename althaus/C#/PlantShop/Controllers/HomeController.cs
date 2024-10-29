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

    public IActionResult Index(Staff staff)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        return View(staff);
    }

    public IActionResult LoginCheck(Staff staff, string email, string password)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        Staff emailStaff = Database.Instance.GetAllStaff().FirstOrDefault(staff => staff.Email == email);
        Staff passwordStaff = Database.Instance.GetAllStaff().FirstOrDefault(staff => staff.Password == password);

        if (staff.Email == emailStaff.ToString() && staff.Password == passwordStaff.ToString())
        {
            Debug.WriteLine("email and password match"); //return RedirectToAction("Index", "Staff");
            Debug.WriteLine("" + staff.Email + "" + staff.Password);
        }
        else
        {
            Debug.WriteLine("Failed find match"); //return View(Index);
        }
        return RedirectToAction("Index", "Home");
    }


    public IActionResult AccountManager(Staff staff, string email, string password)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        Staff emailStaff = Database.Instance.GetAllStaff().FirstOrDefault(staff => staff.Email == email);
        Staff passwordStaff = Database.Instance.GetAllStaff().FirstOrDefault(staff => staff.Password == password);

        if (staff.Email != email && staff.Password != password)
        {
            return View(Error());
        }
        else
        {
            return View(staff);
        }

        //return RedirectToAction("Index", "Staff");
    }

    public IActionResult AccountRegular(Staff staff, string email, string password)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        Staff emailStaff = Database.Instance.GetAllStaff().FirstOrDefault(staff => staff.Email == email);
        Staff passwordStaff = Database.Instance.GetAllStaff().FirstOrDefault(staff => staff.Password == password);

        if (staff.Email != email && staff.Password != password)
        {
            return View(Error());
        }
        else
        {
            return View(staff);
        }

        //return RedirectToAction("Index", "Staff");
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
