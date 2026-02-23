using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_training_management_system.Repository.Models.Configuration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Email).IsUnique();
            builder.Property(e => e.DepartmentId).IsRequired();


            builder.HasMany(e => e.TrainingPrograms)
            .WithMany(t => t.Employees)
            .UsingEntity<EmployeeTrainingProgram>(
            j => j.HasOne(et => et.TrainingProgram).WithMany(t => t.EmployeeTrainingProgram).HasForeignKey(et => et.TrainingProgramId),
            j => j.HasOne(et => et.Employee).WithMany(e => e.EmployeeTrainingPrograms).HasForeignKey(et => et.EmployeeId),
            j =>
               {
                   j.HasKey(et => new { et.EmployeeId, et.TrainingProgramId });
                   j.Property(et => et.EnrollmentDate).HasDefaultValueSql("GETUTCDATE()");
                   j.Property(et => et.Score).HasDefaultValue(0);

            });

            builder.HasData(new Employee { Id = 1, Name = "Krunal", Email = "crunal@company.com", DepartmentId = 1 },
                new Employee { Id = 2, Name = "Charvin", Email = "charvin@company.com", DepartmentId = 2 });
        }
    }
}
