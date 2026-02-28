using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Mission08_Team0314.Models;

public class EFQuadrantsRepository : IQuadrantsRepository
{
    private readonly AppDbContext _context;

    public EFQuadrantsRepository(AppDbContext context)
    {
        _context = context;
    }

    public IQueryable<TodoTask> Tasks => _context.Tasks;
    public IQueryable<Category> Categories => _context.Categories;

    public void Add(TodoTask todoTask)
    {
        _context.Tasks.Add(todoTask);
    }

    public void Update(TodoTask todoTask)
    {
        _context.Tasks.Update(todoTask);
    }

    public void Remove(TodoTask todoTask)
    {
        _context.Tasks.Remove(todoTask);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}

