
using EF_Demo.Model_Configuration;
using Microsoft.EntityFrameworkCore;


namespace EF_Demo
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Batch> Batches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=KRUNAL\SQLEXPRESS;Database=EF_Demo;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new TrainerConfiguration());
            modelBuilder.ApplyConfiguration(new BatchConfiguration());
        }    
    }
}
