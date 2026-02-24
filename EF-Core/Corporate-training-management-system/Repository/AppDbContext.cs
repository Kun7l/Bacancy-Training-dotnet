using Corporate_training_management_system.Repository.Models;
using Corporate_training_management_system.Repository.Models.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Corporate_training_management_system.Repository
{
    public class AppDbContext : DbContext
    {
       public DbSet<TrainingProgram> TrainingPrograms { get; set; }
      public DbSet<Employee> Employees { get; set; }
      public DbSet<Department> Departments { get; set; }

       public DbSet<Trainer> Trainers { get; set; }

        public DbSet<EmployeeTrainingProgram> EmployeeTrainingPrograms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = KRUNAL\\SQLEXPRESS; Database = ctmsDB; Trusted_Connection = True; TrustServerCertificate = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new TrainerConfiguration());
            modelBuilder.ApplyConfiguration(new TrainingProgramConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
        }
    }
}
