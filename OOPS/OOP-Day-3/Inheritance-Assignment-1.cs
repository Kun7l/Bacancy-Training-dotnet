using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Day_3
{
    internal class Employee
    {
        protected int age;
        protected int emp_id;
        protected string name;
        protected double hourly_pay;

        public Employee(int age, int emp_id, string name, double hourly_pay)
        {
            this.age = age;
            this.emp_id = emp_id;
            this.name = name;
            this.hourly_pay = hourly_pay;
        }

        public virtual void Introduce() => Console.WriteLine("Hello i am an employee.");

        public virtual double calculateSalary()
        {
            return hourly_pay;
        }
    }

    class FullTimeEmployee : Employee
    {

       public FullTimeEmployee(int age,int emp_id,string name,double hourly_pay) : base(age, emp_id, name, hourly_pay) { 
            
        }
        public override double calculateSalary()
        {
            int hours_worked;
            int hours_per_day = 8;
            int days_per_week = 5;
            int total_weeks = 52;
            int leaves = 16;
            hours_worked = ((days_per_week * total_weeks) - leaves) * hours_per_day;

            return (hourly_pay * hours_worked);
        }

        public override void Introduce() {
            //Using base keyword to call overriden method
            base.Introduce();

            Console.WriteLine($"Hi, I am {name} and i am a Fulltime employee.");
        }



    }
    class ContractEmployee : Employee
    {
        int project_recieved;
        int hours_per_project;
        public ContractEmployee(int age, int emp_id, string name, double hourly_pay,int project_recieved,int hours_per_project) : base(age, emp_id, name, hourly_pay)
        {
            this.project_recieved = project_recieved;
            this.hours_per_project = hours_per_project;
        }
        public override double calculateSalary()
        {
            int hours_worked;
            hours_worked = project_recieved * hours_per_project;
            
            return (hourly_pay * hours_worked);
        }
        public override void Introduce() => Console.WriteLine($"Hi, I am {name} and i am a Contracted employee.");
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        FullTimeEmployee fte = new FullTimeEmployee(22, 001, "Krunal", 200);
    //        fte.Introduce();
    //        Console.WriteLine("Salary : "+fte.calculateSalary() + " Rs");

    //        Console.WriteLine("-------------------------------");


    //        ContractEmployee cte = new ContractEmployee(23, 002, "Ajay", 200, 10, 25);
    //        cte.Introduce();
    //        Console.WriteLine("Salary : "+cte.calculateSalary() + " Rs");
    //    }

    //}

}
