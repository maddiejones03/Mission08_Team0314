using System.Linq;

namespace Mission08_Team0314.Models
{
    public interface IQuadrantsRepository
    {
        IQueryable<Task> Tasks { get; }
        IQueryable<Category> Categories { get; }
        void Add(Task task);        // Matches your Controller
        void Update(Task task);     // Matches your Controller
        void Remove(Task task);     // Matches your Controller
        void SaveChanges(Task task); // Matches your Controller
    }
}
