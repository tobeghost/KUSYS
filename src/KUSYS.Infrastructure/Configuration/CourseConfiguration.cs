using KUSYS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KUSYS.Infrastructure.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            //Key
            builder.HasKey(x => x.Id);

            //Properties
            builder.Property(x => x.ShortCode).IsRequired();
            builder.Property(x => x.Name).IsRequired();

            //Table
            builder.ToTable("Courses");
        }
    }
}
