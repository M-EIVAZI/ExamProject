namespace ExamProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public virtual ICollection<StudentAsnwers> StudentAsnwers { get; set; }
        public virtual ICollection<ExamStudent> ExamStudents { get; set; }
        public virtual ExamGroup ExamGroup { get; set; }
    }
}
