using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0314.Models;

namespace Mission08_Team0314.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Quadrants()
    {
        return View();
    }

    [HttpGet]
    public IActionResult AddEdit(int id = 0)
    {
        return View();
    }
}