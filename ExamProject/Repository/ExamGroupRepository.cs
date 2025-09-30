using ExamProject.Models;

namespace ExamProject.Repository
{
    public class ExamGroupRepository : GenericRepository<ExamGroup>
    {
        public ExamGroupRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
