using System;
using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0314.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime? DueDate { get; set; }
        public int Quadrant { get; set; }
        public bool Completed { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
