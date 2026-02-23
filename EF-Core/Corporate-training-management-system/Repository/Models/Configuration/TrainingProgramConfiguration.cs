using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_training_management_system.Repository.Models.Configuration
{
    internal class TrainingProgramConfiguration : IEntityTypeConfiguration<TrainingProgram>
    {
        public void Configure(EntityTypeBuilder<TrainingProgram> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasIndex(t => t.Title).IsUnique();
            builder.Property(t => t.Title).HasMaxLength(20);
            builder.Property(t => t.TrainerId).IsRequired();

            builder.HasData(new TrainingProgram { Id = 1, DurationInDays = 20,Title = ".NET",TrainerId = 1, StartDate = DateOnly.FromDateTime(DateTime.Now)});
            
        }
    }
}
