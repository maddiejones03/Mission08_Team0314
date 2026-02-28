namespace Mission08_Team0314.Models;
using System.Collections.Generic;
public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;

    // Navigation
    public ICollection<TodoTask> Tasks { get; set; }
}
