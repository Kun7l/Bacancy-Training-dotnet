
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Demo.Model_Configuration
{
    internal class TrainerConfiguration : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).HasMaxLength(50);
            builder.Property(t => t.ExperienceYears).IsRequired();
            builder.HasData(new Trainer {Id=1, Name = "Jay", ExperienceYears = 3 },new Trainer { Id=2,Name="Rohit",ExperienceYears=4});
        }
    }
}
