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
                .HasForeignKey(x => x.QuestionId);
            builder.HasOne(x => x.ExamStudent)
                .WithMany(x => x.StudentAsnwers)
                .HasForeignKey(x => x.ExamStudentId);
        }
    }
}
