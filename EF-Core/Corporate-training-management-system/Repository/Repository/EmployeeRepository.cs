using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
            try
            {
                employees.Add(new Models.Employee { Name = name, Email = email, DepartmentId = deptId });
                _context.SaveChanges();
            }
            catch (DbException ex) {
                Console.WriteLine("SQL Exception");
            }
        }

        public void EnrollEmployeeInTraining(int employeeId,int tpId)
        {
            var employee = _context.Employees.Include(e=>e.TrainingPrograms).SingleOrDefault(e=>e.Id == employeeId);
            var tp = _context.TrainingPrograms.FirstOrDefault(tp=>tp.Id == tpId);

            var exists = _context.EmployeeTrainingPrograms.Any(et=>et.EmployeeId == employeeId && et.TrainingProgramId == tpId);

            if (employee != null)
            {
                if (tp != null)
                {
                    if (exists)
                    {
                        Console.WriteLine("Already enrolled");
                    }
                    else
                    {
                        employee.TrainingPrograms.Add(tp);
                        _context.SaveChanges();
                    }

                }
                else
                {
                    Console.WriteLine($"Training program for id : {tpId} does not exists.");
                }
            }
            else
            {
                Console.WriteLine($"Employee for id : {employeeId} does not exits.");
            }
        }
    }
}
