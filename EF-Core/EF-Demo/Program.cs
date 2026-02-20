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

                bool flag = true;

                int choice = 0;

                while (flag)
                {
                    Console.WriteLine();
                    Console.WriteLine("----- Choose Operation -----");
                    Console.WriteLine("1. Add student");
                    Console.WriteLine("2. Add course");
                    Console.WriteLine("3. Show All Student");
                    Console.WriteLine("4. Show All Course");
                    Console.WriteLine("5. Enroll student in course");
                    Console.WriteLine("6. Show Course with all students");
                    Console.WriteLine("7. Show Trainer with all branches ");
                    Console.WriteLine("8. Create Batch");
                    Console.WriteLine("9. Update Student Email");
                    Console.WriteLine("10. Add Trainer");
                    Console.WriteLine("11. Delete Trainer");
                    Console.WriteLine("12. Eager Loading Example");
                    Console.WriteLine("13. Lazy Loading Example");
                    Console.WriteLine("14. N+1 Query and solve with Include()");
                    Console.WriteLine("20. Exit");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Email");
                            string email = Console.ReadLine();

                            rs.AddStudent(new Student { Name = name, Email = email, CreatedDate = DateOnly.FromDateTime(DateTime.Now) });
                            break;

                        case 2:
                            Console.WriteLine("Enter Title");
                            string title = Console.ReadLine();
                            Console.WriteLine("Enter Fees");
                            double fees = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Duration(In months)");
                            int durationInMonths = Convert.ToInt32(Console.ReadLine());

                            rs.AddCourse(new Course { Title = title, Fees = fees, DurationInMonths = durationInMonths });
                            break;

                        case 3:
                            foreach (var student in rs.ShowAllStudents())
                            {
                                Console.WriteLine(student.Id + " " + student.Name + " " + student.Email + " " + student.CreatedDate);
                            }
                            break;

                        case 4:
                            foreach (var course in rs.ShowAllCourses())
                            {
                                Console.WriteLine(course.Id + " " + course.Title + " " + course.Fees + " " + course.DurationInMonths);
                            }
                            break;

                        case 5:
                            foreach (var student in rs.ShowAllStudents())
                            {
                                Console.WriteLine(student.Id + " " + student.Name + " " + student.Email + " " + student.CreatedDate);
                            }
                            foreach (var course in rs.ShowAllCourses())
                            {
                                Console.WriteLine(course.Id + " " + course.Title + " " + course.Fees + " " + course.DurationInMonths);
                            }
                            Console.WriteLine("Enter Student Id");
                            int studentId = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Course Id");
                            int courseId = Convert.ToInt32(Console.ReadLine());

                            rs.EnrollStudentInCourse(studentId, courseId);
                            break;

                        case 6:
                            Console.WriteLine("Enter Course Id");
                            rs.ShowCourseWithStudents(Convert.ToInt32(Console.ReadLine()));
                            break;

                        case 7:
                            Console.WriteLine("Enter Trainer Id");
                            rs.ShowTrainerWithBatches(Convert.ToInt32(Console.ReadLine()));
                            break;

                        case 8:
                            Console.WriteLine("Enter Course Id");
                            int cId = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Trainer Id");
                            int tId = Convert.ToInt32(Console.ReadLine());
                            rs.CreateBatch(cId, tId, DateOnly.FromDateTime(DateTime.Now));

                            break;

                        case 9:
                            Console.WriteLine("Enter Student Id :");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter New Email :");
                            string? newEmail = Console.ReadLine();
                            try
                            {
                                if (newEmail != null)
                                {
                                    rs.UpdateStudentEmail(id, newEmail);
                                }
                                else
                                {
                                    Console.WriteLine("Enter Valid Email");
                                }
                            }
                            catch (StudentNotFound s)
                            {
                                Console.WriteLine(s.Message);
                            }
                            break;

                            case 10:
                            Console.WriteLine("Enter Trainer Name");
                            string? trainerName = Console.ReadLine();
                            if (trainerName==null)
                            {
                                Console.WriteLine("Name cannot be empty");
                                break;
                            }
                            Console.WriteLine("Enter Experience in Years");
                            int trainerExp =Convert.ToInt32(Console.ReadLine());
                            rs.AddTrainer(trainerName, trainerExp);
                            break;

                            case 11:
                            Console.WriteLine("Enter Trainer Id:");
                            tId = Convert.ToInt32(Console.ReadLine());
                            rs.DeleteTrainer(tId);
                            break;

                            case 12:
                            rs.EagerLoadingExample(2);
                            break;
                        case 13:
                            rs.LazyLoading(2);
                            break;
                        case 14:
                            rs.NplusOne();
                            break;

                        case 20:
                            flag = false;
                            break;
                    }
                }
            }
        }
    }
}
