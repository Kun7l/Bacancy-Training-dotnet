using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Day_3
{
    internal class Person
    {
        public virtual void Introduce() => Console.WriteLine("Hi i am a Person.");
        public void Greet() => Console.WriteLine("Good morning from People.");
    }
    class Student : Person
    {
        public override void Introduce() => Console.WriteLine("Hi i am a Student.");
        public new void Greet() => Console.WriteLine("Good morning from Student.");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student();
            student.Introduce();
            student.Greet();

            Console.WriteLine("-----------------------");

            Student student2 = new Student();
            student2.Introduce();
            student2.Greet();

            //In case of virtual-override the overrided method will be called regarless of the reference
            //student in both
            //In case of new reference class method will be called
            //Person in first
            //Student in second
        }
    }
}
