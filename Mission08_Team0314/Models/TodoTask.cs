using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_Team0314.Models;

public class TodoTask
{
    [Key]
    public int TaskId { get; set; }

    public string TaskName { get; set; } = string.Empty;

    public DateTime? DueDate { get; set; }

    public int Quadrant { get; set; }   // 1,2,3,4

    public bool Completed { get; set; }

    // FK relationship
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}