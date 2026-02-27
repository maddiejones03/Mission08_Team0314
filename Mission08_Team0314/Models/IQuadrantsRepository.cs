namespace Mission08_Team0314.Models;

public interface IQuadrantsRepository
{
    IQueryable<TodoTask> Tasks { get; }
    IQueryable<Category> Categories { get; }

    void Add(TodoTask todoTask);
    void Update(TodoTask todoTask);
    void Remove(TodoTask todoTask);
    void SaveChanges();
}