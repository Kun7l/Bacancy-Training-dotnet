using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_training_management_system.Repository.Models.Configuration
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name).HasMaxLength(20);
            builder.HasData(new Department { Id = 1, Name = "IT", Location = "Ahmedabad" }, new Department { Id = 2, Name = "HR", Location = "Ahmedabad" });
           
        }
    }
}
