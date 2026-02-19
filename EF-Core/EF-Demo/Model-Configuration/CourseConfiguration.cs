using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Demo.Model_Configuration
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(course => course.Id);
            builder.Property(course=>course.Title).IsRequired();
            builder.Property(course => course.Fees).HasPrecision(10, 2);
        }
    }
}
