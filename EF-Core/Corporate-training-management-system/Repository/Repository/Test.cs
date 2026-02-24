using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_training_management_system.Repository.Repository
{
    public class Test
    {
        private readonly AppDbContext _context;
        public Test(AppDbContext context)
        {
            _context = context;
        }

        public void Test1() { 
            var employee = _context.Employees.Include(e=>e.TrainingPrograms).FirstOrDefault(e=>e.Id == 1);
            var tp = _context.TrainingPrograms.FirstOrDefault(tp=>tp.Id == 1);
            Console.WriteLine(employee.Name);
            Console.WriteLine(tp.Title);
            employee.TrainingPrograms.Add(tp);
            _context.SaveChanges();
                
        }
    }
}
