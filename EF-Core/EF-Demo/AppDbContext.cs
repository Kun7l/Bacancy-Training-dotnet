using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EF_Demo
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=KRUNAL\SQLEXPRESS;Database=EF_Demo;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
