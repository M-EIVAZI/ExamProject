namespace ExamProject.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int ExamId { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public int CorrectAnswer { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual ICollection<ExamStudent> ExamStudents { get; set; }
        public virtual ICollection<StudentAsnwers> StudentAsnwers { get; set; }
    }
}
