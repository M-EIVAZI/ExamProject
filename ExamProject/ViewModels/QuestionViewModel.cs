namespace ExamProject.ViewModels
{
    public class QuestionViewModel
    {
        public int QuestionId { get; set; }
        public string Description { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public int SelectedAnswer { get; set; }
    }
}
