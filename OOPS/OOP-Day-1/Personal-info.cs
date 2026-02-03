using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Day_1
{
    public partial class Student
    {
        public int id;
        public string name;
        public int age;

        public Student(int  id, string name, int age, int std, int marks)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.std = std;
            this.marks = marks;
        }

        
        public void printProfile()
        {
            Console.WriteLine("--- Personal Details ---");
            Console.WriteLine("Id : "+id);
            Console.WriteLine("Name : "+name);
            Console.WriteLine("Age : "+age);
            Console.WriteLine("--- Academic Details ---");
            Console.WriteLine("STD : "+std);
            Console.WriteLine("Marks : " + marks);
        }
    }

    public class PrintProfile
    {
       static void Main(string[] args)
        {
            Student s1 = new Student(1, "krunal", 12, 12, 90);
            Console.WriteLine(s1.marks);
        }
    }
}
