namespace ExamProject.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int GroupId { get; set; }
        public DateTime StartDate { get; set; }
        public int DurationInMinutes { get; set; }
        public virtual ExamGroup ExamGroup { get; set; }
        public virtual ICollection<ExamStudent> ExamStudents { get; set; }
    }
}
