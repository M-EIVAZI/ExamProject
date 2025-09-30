using ExamProject.Models;

namespace ExamProject.Repository
{
    public class QuestionRepository : GenericRepository<Questions>
    {
        public QuestionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
