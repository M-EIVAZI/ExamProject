using ExamProject.Interfaces;
using ExamProject.Models;

namespace ExamProject.Repository
{
    public class ExamRepository : GenericRepository<Exam>
    {
        public ExamRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
