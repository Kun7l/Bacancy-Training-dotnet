using LINQ_Day_3;
using Models;
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
            departments.Add(new Department(1, "IT"));
            departments.Add(new Department(2, "Sales"));
            departments.Add(new Department(3, "HR"));
            departments.Add(new Department(4, "Marketing"));

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "Krunal", 50000, 1, "surat"));
            employees.Add(new Employee(2, "Parth", 30000, 1, "palanpur"));
            employees.Add(new Employee(3, "Chintan", 40000, 2, "bhuj"));
            employees.Add(new Employee(4, "Jenil", 25000, 3, "rajkot"));
            employees.Add(new Employee(5, "Om", 35000, 3, "bhavnagar"));
            employees.Add(new Employee(6, "Bhavish", 20000, 1, "porbandar"));

            List<Employee2> employees2 = new List<Employee2>();
            employees2.Add(new Employee2(1, "Krunal", 50000, "IT", "surat"));
            employees2.Add(new Employee2(2, "Parth", 30000, "IT", "palanpur"));
            employees2.Add(new Employee2(3, "Chintan", 40000, "HR", "bhuj"));
            employees2.Add(new Employee2(4, "Jenil", 25000, "Sales", "rajkot"));
            employees2.Add(new Employee2(5, "Om", 35000, "Sales", "bhavnagar"));
            employees2.Add(new Employee2(6, "Bhavish", 20000, "IT", "porbandar"));

            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Mishu", 35));
            students.Add(new Student(2, "Daksh", 45));
            students.Add(new Student(3, "Jahnvi", 33));
            students.Add(new Student(4, "Ishu", 80));
            students.Add(new Student(5, "Sujal", 50));

            List<Order> orders = new List<Order>();
            orders.Add(new Order(1, "Krunal", new List<OrderItem> { new OrderItem("Pencil", 100), new OrderItem("Pen", 200) }));
            orders.Add(new Order(1, "Sahil", new List<OrderItem> { new OrderItem("Pencil", 250), new OrderItem("Eraser", 50) }));
            orders.Add(new Order(1, "Ajay", new List<OrderItem> { new OrderItem("Marker", 150), new OrderItem("Brush", 200) }));

            Queries q = new Queries();
            //q.Task1(employees, departments);
            //q.Task2(students);
            //q.Task3(orders);
            //q.Task4(employees, departments);
            //q.Task5(employees, departments);
            //q.Task6(employees, departments);
            //q.Task7(orders);
            //q.Task8(employees);
            //q.Task9(employees2);
            
        }
    }
}
