using ExamProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamProject.Configurations
{
    public class ExamStudentConfig : IEntityTypeConfiguration<ExamStudent>
    {
        public void Configure(EntityTypeBuilder<ExamStudent> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Student)
                .WithMany(x => x.ExamStudents)
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Exam)
                .WithMany(x => x.ExamStudents)
                .HasForeignKey(x => x.ExamId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
