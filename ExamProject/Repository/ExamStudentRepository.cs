using ExamProject.Models;

namespace ExamProject.Repository
{
    public class ExamStudentRepository : GenericRepository<ExamStudent>
    {
        public ExamStudentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
