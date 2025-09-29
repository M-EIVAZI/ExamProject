namespace ExamProject.Models
{
    public class StudentAsnwers
    {
        public int Id { get; set; }
        public int ExamStudentId {  get; set; }
        public int QuestionId { get; set; }
        public int SelectedOption {  get; set; }
        public DateTime AnsweredAt { get; set; }
        public bool IsOnTime {  get; set; }
        public virtual ExamStudent ExamStudent { get; set; }
        public virtual Questions Question { get; set; }
    }
}
