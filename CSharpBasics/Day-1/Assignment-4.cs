using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Assignment_4
    {
        class Student
        {
            //nulable 
            int? age = null;
            
            string? name = null;
            public Student(int? age, string? name)
            {
                this.age = age;
                this.name = name;
            }
            public void display()
            {
                //use of hasValue
                if (age.HasValue)
                {
                    Console.WriteLine(age);
                }
                else
                {
                    Console.WriteLine("Age not provided");
                }
                
                //Null coalesing
                string displayName = name ?? "Guest";
                Console.WriteLine("Hello "+ displayName);       
            }

        }

        public static void Main(String[] args)
        {
            Student student = new Student(null,null);
            student.display();
        }
    }
}