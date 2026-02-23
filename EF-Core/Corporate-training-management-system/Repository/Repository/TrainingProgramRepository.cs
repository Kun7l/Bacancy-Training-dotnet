using Corporate_training_management_system.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_training_management_system.Repository.Repository
{
    internal class TrainingProgramRepository
    {
        private readonly AppDbContext _context;
        public TrainingProgramRepository(AppDbContext context) {
        _context = context;
        }

        public void CreateTrainingPogram(string title,int durationInDays,DateOnly startDate,int trainerId)
        {
            var result = _context.TrainingPrograms;

            try
            {
                result.Add(new Models.TrainingProgram { Title = title, DurationInDays = durationInDays, StartDate = startDate, TrainerId = trainerId });
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(title + " already exits. Add a unique title.");
            }
            
        }

        public void ShowTrainingProgram(int tpId)
        {
            var tp = _context.TrainingPrograms.Include(tp=>tp.Trainer).FirstOrDefault(tp=>tp.Id == tpId);

            Console.WriteLine("Title : " + tp.Title);
            Console.WriteLine("Trainer Name : "+tp.Trainer.Name);
            Console.WriteLine("Duration : "+tp.DurationInDays + " days");

           

            _context.Entry(tp).Collection(tp => tp.Employees).Load();
           
            
            
            if (tp.Employees.Count != 0)
            {
                Console.WriteLine("Enrolled employees");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine(" Id | Name | Department | Score");

                foreach (var employee in tp.Employees)
                {
                    Console.WriteLine(" " + employee.Id + " | " + employee.Name + " | " + employee.Department.Name + " | " + employee.EmployeeTrainingPrograms.First(e=>e.TrainingProgramId == tpId).Score);
                }
            }
            else
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("No Employees enrolled yet.");
            }
        }

        public void DepartmentReport(int deptId)
        {
            var dept = _context.Departments.Include(d=>d.Employees).ThenInclude(e=>e.EmployeeTrainingPrograms).FirstOrDefault(d=>d.Id == deptId);
            Console.WriteLine("Department Name : "+dept.Name);
            Console.WriteLine("Total employees : "+dept.Employees.Count());
            int total = 0;
            foreach (var item in dept.Employees)
            {
                total += item.EmployeeTrainingPrograms.Count();
            }
            Console.WriteLine("Employees Enrolled in Training " +total);

        }

        public void UpdateScore(int empId, int tpId,int score)
        {
         var emps = _context.Employees.Include(e=>e.EmployeeTrainingPrograms).SingleOrDefault(e=>e.Id == empId);
            var emp = emps.EmployeeTrainingPrograms.SingleOrDefault(e=>e.TrainingProgramId == tpId);

            if (score <= 100)
            {
                emp.Score = score;
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Marks cannot be more than 100");
            }
        }

        public void DeleteTrainingProgram(int tpId)
        {
            var tp = _context.TrainingPrograms.SingleOrDefault(tp=>tp.Id == tpId);

            if (tp!=null)
            {
                _context.TrainingPrograms.Remove(tp);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Cant find tp for this id");
            }
        }
    }
}
