using ExamProject.Models;

namespace ExamProject.Interfaces
{
    public interface IExamStudentRepository:IGenericRepository<ExamStudent>
    {
        public  Task<bool> IsCompletedAsync(int studentId, int examId);

    }
}
