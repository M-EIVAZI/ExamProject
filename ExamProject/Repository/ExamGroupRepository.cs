using ExamProject.Interfaces;
using ExamProject.Models;

namespace ExamProject.Repository
{
    public class ExamGroupRepository : GenericRepository<ExamGroup>,IExamGroupRepository
    {
        public ExamGroupRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
