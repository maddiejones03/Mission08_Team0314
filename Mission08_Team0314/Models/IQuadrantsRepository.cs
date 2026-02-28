namespace Mission08_Team0314.Models;
using System.Linq;
public interface IQuadrantsRepository
{
    IQueryable<TodoTask> Tasks { get; }
    IQueryable<Category> Categories { get; }

    void Add(TodoTask todoTask);
    void Update(TodoTask todoTask);
    void Remove(TodoTask todoTask);
    void SaveChanges();
}