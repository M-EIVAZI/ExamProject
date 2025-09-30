using ExamProject.ViewModels;

namespace ExamProject.Interfaces
{
    public interface ITestService
    {
        public Task<bool> IsExamCompletedAsync(int studentId,int examid);
        public Task<bool> IsExamTimeValidAsync(int examid);
        Task<ExamStartViewModel> GetExamWithQuestionsViewAsync(int examid, int studentid);
        Task ProccessFinishedExamAsync(ExamStudentViewModel model);

    }
}
