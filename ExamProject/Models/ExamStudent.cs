namespace ExamProject.Models
{
    public class ExamStudent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public DateTime FinishedAt { get; set; }
        public bool IsCompleted { get; set; }
        public virtual Student Student { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual ICollection<StudentAsnwers> StudentAsnwers { get; set; }
    }
}
