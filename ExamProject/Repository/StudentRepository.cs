using ExamProject.Models;

namespace ExamProject.Repository
{
    public class StudentRepository : GenericRepository<Student>
    {
        public StudentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
