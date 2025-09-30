using ExamProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamProject.Configurations
{
    public class QuestionConfig : IEntityTypeConfiguration<Questions>
    {
        public void Configure(EntityTypeBuilder<Questions> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.HasOne(x => x.Exam)
                .WithMany(x => x.Questions)
                .HasForeignKey(x => x.ExamId);
            builder.Property(x => x.Description)
                .HasMaxLength(70);
        }
    }
}
