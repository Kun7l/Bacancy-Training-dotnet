using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_training_management_system.Repository.Repository
{
    public class EmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context) {
        _context = context;
        }

        public void RegisterEmployee(string name, string email, int deptId)
        {
            var employees = _context.Employees;
            employees.Add(new Models.Employee { Name = name, Email = email,DepartmentId = deptId });
            _context.SaveChanges();
        }

        public void EnrollEmployeeInTraining(int employeeId,int tpId)
        {
            var employee = _context.Employees.Include(e=>e.TrainingPrograms).SingleOrDefault(e=>e.Id == employeeId);
            var tp = _context.TrainingPrograms.FirstOrDefault(tp=>tp.Id == tpId);

            employee.TrainingPrograms.Add(tp);
            _context.SaveChanges();
        }
    }
}
