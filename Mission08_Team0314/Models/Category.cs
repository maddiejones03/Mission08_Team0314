namespace Mission08_Team0314.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;

    // Navigation
    public ICollection<TodoTask> Tasks { get; set; }
}