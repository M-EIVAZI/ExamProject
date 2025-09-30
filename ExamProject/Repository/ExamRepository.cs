using ExamProject.Interfaces;
using ExamProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamProject.Repository
{
    public class ExamRepository : GenericRepository<Exam>
    {
        private AppDbContext _context;
        public ExamRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<Exam> GetExamWithQuestions(int id)
        {
            return await _context.exams.Include(x => x.Questions).FirstOrDefaultAsync(x=>x.Id == id);
        }
    }
}
