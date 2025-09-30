using ExamProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamProject.Repository
{
    public class ExamStudentRepository : GenericRepository<ExamStudent>
    {
        private AppDbContext _appDbContext;
        public ExamStudentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<bool> IsCompletedAsync(int studentId, int examId)
        {
            var res = await _appDbContext.examStudents.FirstOrDefaultAsync(x => x.StudentId == studentId && x.ExamId == examId);
            return res.IsCompleted;
        }

    }
}
