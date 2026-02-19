
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Demo.Model_Configuration
{
    internal class BatchConfiguration : IEntityTypeConfiguration<Batch>

    {
        public void Configure(EntityTypeBuilder<Batch> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b=>b.StartDate).IsRequired();
            builder.HasData(new Batch {Id=1, StartDate = new DateOnly(2026, 3, 1) , TrainerId = 1, CourseId = 1}, new Batch {Id=2, StartDate = new DateOnly(2026, 4, 1), TrainerId = 2, CourseId = 1 });
           
        }
    }
}
