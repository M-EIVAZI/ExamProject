using ExamProject.Models;

namespace ExamProject.Repository
{
    public class StudentAsnwerRepository : GenericRepository<StudentAsnwers>
    {
        private AppDbContext _appDbContext;


        public StudentAsnwerRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task AddRangeAsync(List<StudentAsnwers> list)
        {
            await _appDbContext.studentsAsnwers.AddRangeAsync(list);
        }
    }
}
