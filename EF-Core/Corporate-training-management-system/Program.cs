using Corporate_training_management_system.Repository;
using Corporate_training_management_system.Repository.Models;
using Corporate_training_management_system.Repository.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_training_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var context = new AppDbContext())
            {
                Test ts = new Test(context);
                TrainingProgramRepository tpr = new TrainingProgramRepository(context);
                EmployeeRepository emp = new EmployeeRepository(context);


                bool flag = true;

                int choice = 0;

                while (flag)
                {
                    Console.WriteLine();
                    Console.WriteLine("----- Choose Operation -----");
                    Console.WriteLine("1.Create Training Program");
                    Console.WriteLine("2.Register Employee");
                    Console.WriteLine("3.Enroll Employee in Training");
                    Console.WriteLine("4.Show Training Details(With Employees)");
                    Console.WriteLine("5.Show Department Report");
                    Console.WriteLine("6.Update Employee Performance");
                    Console.WriteLine("7.Delete Training Program");
                    Console.WriteLine("8.Exit");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Title");
                            string title = Console.ReadLine();
                            Console.WriteLine("Enter Duration in Days");
                            int days = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Trainer ID");
                            int trainerId = Convert.ToInt32(Console.ReadLine());
                           

                            if (trainerId >0)
                            {
                                tpr.CreateTrainingPogram(title, days, DateOnly.FromDateTime(DateTime.Now), trainerId);
                            }
                            else
                            {
                                Console.WriteLine("Enter Valid trainer id");
                            }

                            break;

                        case 2:
                            Console.WriteLine("Enter Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Email");
                            string email = Console.ReadLine();
                            Console.WriteLine("Enter Department ID");
                            int deptId = Convert.ToInt32(Console.ReadLine());

                            emp.RegisterEmployee(name,email, deptId);

                            break;

                        case 3:
                            Console.WriteLine("Enter Employee Id");
                            int empId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Training Program Id");
                            int tpId = Convert.ToInt32(Console.ReadLine());
                            emp.EnrollEmployeeInTraining(empId, tpId);
                            break;

                            case 4:
                            Console.WriteLine("Enter Training program Id");
                            int Id = Convert.ToInt32(Console.ReadLine());
                            tpr.ShowTrainingProgram(Id);
                            break;

                        case 5:
                            Console.WriteLine("Enter Department Id");
                             deptId = Convert.ToInt32(Console.ReadLine());
                            tpr.DepartmentReport(deptId);
                            break;

                        case 6:
                            Console.WriteLine("Enter Employee Id");
                             empId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Training Id");
                            int tnrId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Updated Score");
                            int score = Convert.ToInt32(Console.ReadLine());
                            tpr.UpdateScore(empId,tnrId,score);
                            break;

                        case 7:
                            Console.WriteLine("Enter Training program Id");
                            int tprId = Convert.ToInt32(Console.ReadLine());
                            tpr.DeleteTrainingProgram(tprId);
                            break;
                        case 8:
                            flag = false;
                           
                            break;
                    }
                }
            }
        }
    }
}
