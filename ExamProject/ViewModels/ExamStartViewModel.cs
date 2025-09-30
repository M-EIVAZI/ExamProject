namespace ExamProject.ViewModels
{
    public class ExamStartViewModel
    {
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public int DurationInMinutes { get; set; }


        public List<QuestionViewModel> Questions { get; set; }
    }
}
