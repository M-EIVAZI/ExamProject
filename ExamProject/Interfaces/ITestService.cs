namespace ExamProject.Interfaces
{
    public interface ITestService
    {
        public Task<bool> IsExamCompletedAsync(int studentId,int examid);
        public Task<bool> IsExamTimeValidAsync(int examid);
        public Task<>
    }
}
