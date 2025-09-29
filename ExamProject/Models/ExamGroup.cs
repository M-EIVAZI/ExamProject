namespace ExamProject.Models
{
    public class ExamGroup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
