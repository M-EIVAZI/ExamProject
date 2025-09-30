using ExamProject.Models;

namespace ExamProject.Repository
{
    public class StudentAsnwerRepository : GenericRepository<StudentAsnwers>
    {
        public StudentAsnwerRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
