using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Services;

namespace Pogram
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee(1, "krunal", 31000, "IT", "surat"));
            list.Add(new Employee(2, "charvin", 20000, "HR", "surat"));
            list.Add(new Employee(3, "parth", 23000, "IT", "palanpur"));
            list.Add(new Employee(4, "chintan", 33000, "Civil", "bhuj"));
            list.Add(new Employee(5, "jenil", 35000, "IT", "rajkot"));

            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Mishu", 75));
            students.Add(new Student(2, "Daksh", 45));
            students.Add(new Student(3, "Jahnvi", 33));
            students.Add(new Student(4, "Ishu", 80));
            students.Add(new Student(5, "Sujal", 50));

            List<Order> orders = new List<Order>();
            orders.Add(new Order(1, "Krunal", new List<OrderItem> { new OrderItem("Pencil", 100), new OrderItem("Pen", 200) }));
            orders.Add(new Order(1, "Sahil", new List<OrderItem> { new OrderItem("Book", 250), new OrderItem("Eraser", 50) }));
            orders.Add(new Order(1, "Ajay", new List<OrderItem> { new OrderItem("Marker", 150), new OrderItem("Brush", 200) }));


            LINQ_Assignment ls = new LINQ_Assignment();
            ls.Task8(orders);

        }
    }
}
