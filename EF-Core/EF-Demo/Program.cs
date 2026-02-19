using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Text;


namespace EF_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AppDbContext context = new AppDbContext())
            {
                Repository rs = new Repository(context);

                //Console.WriteLine("----- Choose Operation -----");
                //Console.WriteLine("1. Add student");
                //Console.WriteLine("2. Add course");
                //Console.WriteLine("3. Show All Student");
                //Console.WriteLine("4. Show All Course");

                //int choice = 0;

                //choice = Convert.ToInt32(Console.ReadLine());

                //switch (choice) {
                //    case 1:
                //        Console.WriteLine("Enter Name");
                //        string name = Console.ReadLine();
                //        Console.WriteLine("Enter Email");
                //        string email = Console.ReadLine();

                //        rs.AddStudent(new Student { Name = name, Email = email, CreatedDate = DateOnly.FromDateTime(DateTime.Now) });
                //        break;

                //        case 2:
                //        Console.WriteLine("Enter Title");
                //        string title = Console.ReadLine();
                //        Console.WriteLine("Enter Fees");
                //        double fees = Convert.ToDouble(Console.ReadLine());
                //        Console.WriteLine("Enter Duration(In months)");
                //        int durationInMonths = Convert.ToInt32(Console.ReadLine());

                //        rs.AddCourse(new Course { Title = title, Fees = fees, DurationInMonths = durationInMonths });
                //        break;

                //        case 3:
                //        foreach(var student in rs.ShowAllStudents())
                //        {
                //            Console.WriteLine(student.Id +" " +student.Name +" "+student.Email+ " "+student.CreatedDate);
                //        }
                //        break;

                //        case 4:
                //        foreach (var course in rs.ShowAllCourses())
                //        {
                //            Console.WriteLine(course.Id +" "+course.Title +" "+course.Fees +" "+course.DurationInMonths);
                //        }
                //        break;

               
                //}
            }

        }
    }
}
