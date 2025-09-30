using ExamProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamProject.Configurations
{
    public class ExamGroupConfig : IEntityTypeConfiguration<ExamGroup>
    {
        public void Configure(EntityTypeBuilder<ExamGroup> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
