namespace ExamProject.ViewModels
{
    public class ExamStudentViewModel
    {
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public Dictionary<int,int> Answers { get; set; }

    }
}
