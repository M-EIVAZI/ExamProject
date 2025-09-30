using ExamProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamProject
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Exam> exams { get; set; }
        public DbSet<ExamGroup> examGroups { get; set; }
        public DbSet<ExamStudent> examStudents { get; set; }
        public DbSet<Questions> questions { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<StudentAsnwers> studentsAsnwers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
