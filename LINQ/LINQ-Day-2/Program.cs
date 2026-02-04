using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department(1,"IT"));
            departments.Add(new Department(2,"Sales"));
            departments.Add(new Department(3,"HR"));

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "Krunal", 50000, 1, "surat"));
            employees.Add(new Employee(2, "Parth", 30000, 1, "palanpur"));
            employees.Add(new Employee(3, "Chintan", 40000, 2, "bhuj"));
            employees.Add(new Employee(4, "Jenil", 25000, 3, "rajkot"));
            employees.Add(new Employee(5, "Om", 35000, 3, "bhavnagar"));
            employees.Add(new Employee(6, "Bhavish", 20000, 1, "porbandar"));

            List<int> list1 = new List<int>() { 1,2,3,4,5,6};
            List<int> list2= new List<int>() { 4,5,6,7,8,9};


            Queries q = new Queries();


            //q.Task1(employees, departments);
            //q.Task2(employees, departments);
            //q.Task3(employees, departments);
            //q.Task4(employees, departments);
            q.Task5(list1, list2);



        }
    }
}
