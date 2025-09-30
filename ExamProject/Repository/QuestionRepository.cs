using ExamProject.Interfaces;
using ExamProject.Models;

namespace ExamProject.Repository
{
    public class QuestionRepository : GenericRepository<Questions>,IQuestionRepository
    {
        public QuestionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
