using ExamProject.Interfaces;
using ExamProject.Models;

namespace ExamProject.Repository
{
    public class StudentRepository : GenericRepository<Student>,IStudentRepository
    {
        public StudentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
