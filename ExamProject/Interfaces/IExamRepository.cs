using ExamProject.Models;

namespace ExamProject.Interfaces
{
    public interface IExamRepository:IGenericRepository<Exam>
    {
        public Task<Exam> GetExamWithQuestions(int id);

    }
}
