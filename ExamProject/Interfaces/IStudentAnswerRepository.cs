using ExamProject.Models;

namespace ExamProject.Interfaces
{
    public interface IStudentAnswerRepository:IGenericRepository<StudentAsnwers>
    {
        public Task AddRangeAsync(List<StudentAsnwers> list);

    }
}
