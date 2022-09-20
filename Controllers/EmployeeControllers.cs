using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LuongTrungSonBTH.Models;

namespace LuongTrungSonBTH.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Employee std)
    {
        int ID = std.EmployeeID;
        String Name = std.EmployeeName;
        int Age = std.EmployeeAge;
        int Phone = std.EmployeePhone;
        String Address = std.EmployeeAddress;
        ViewBag.ID = std.EmployeeID;
        ViewBag.Name = std.EmployeeName;
        ViewBag.Age = std.EmployeeAge;
        ViewBag.Phone = std.EmployeePhone;
        ViewBag.Address = std.EmployeeAddress;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}