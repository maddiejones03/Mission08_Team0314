using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0314.Models;
using Task = Mission08_Team0314.Models.Task;

namespace Mission08_Team0314.Controllers;

public class HomeController : Controller
{
    private readonly IQuadrantsRepository _repo;

    public HomeController(IQuadrantsRepository repo)
    {
        _repo = repo;
    }
    
    // Landing page
    public IActionResult Index()
    {
        return View("Quadrants");
    }

    [HttpGet]
    public IActionResult Quadrants()
    {
        var tasks = _repo.Tasks
            .Where(t => !t.Completed)
            .OrderBy(t => t.Quadrant)
            .ThenBy(t => t.DueDate)
            .ToList();
        
        return View(tasks);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View("AddEdit", new TodoTask());
    }

    [HttpPost]
    public IActionResult Add(TodoTask task)
    {
        _repo.Add(task);
        _repo.SaveChanges(task);
        
        return RedirectToAction("Quadrants");
    }
    
    
    [HttpGet]
    public IActionResult Edit(int TaskId)
    {
        var TaskInfo = _repo.Tasks.SingleOrDefault(t => t.TaskId == TaskId);
        if (TaskInfo == null) return NotFound();
        
        return View("AddEdit",TaskInfo);
    }

    [HttpPost]
    public IActionResult Edit(TodoTask task)
    {
        _repo.Update(task);
        _repo.SaveChanges(task);
        return RedirectToAction("Quadrants");
    }

    [HttpGet]
    public IActionResult Delete(int TaskId)
    {
        var task = _repo.Tasks.SingleOrDefault(t => t.TaskId == TaskId);
        if (task == null) return NotFound();
        return View(task);
    }
    
    [HttpPost]
    public IActionResult Delete(TodoTask task)
    {
        _repo.Remove(task);
        _repo.SaveChanges(task);
        return RedirectToAction("Quadrants");
    }
}