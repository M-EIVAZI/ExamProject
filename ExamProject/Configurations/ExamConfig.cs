using ExamProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace ExamProject.Configurations
{
    public class ExamConfig : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.ExamGroup)
                .WithMany(x => x.Exams)
                .HasForeignKey(x => x.GroupId);

        }
    }
}
