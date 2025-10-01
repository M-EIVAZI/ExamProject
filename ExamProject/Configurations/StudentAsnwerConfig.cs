using ExamProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamProject.Configurations
{
    public class StudentAsnwerConfig : IEntityTypeConfiguration<StudentAsnwers>
    {
        public void Configure(EntityTypeBuilder<StudentAsnwers> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.HasOne(x => x.Question)
                .WithMany(x => x.StudentAsnwers)
                .HasForeignKey(x => x.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.ExamStudent)
                .WithMany(x => x.StudentAsnwers)
                .HasForeignKey(x => x.ExamStudentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
