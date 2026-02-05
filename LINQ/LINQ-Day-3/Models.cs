using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int DepartmentId { get; set; }
        public string City { get; set; }

        public Employee(int EmployeeID, string Name, double Salary, int DepartmentId, string city)
        {
            this.EmployeeID = EmployeeID;
            this.Name = Name;
            this.Salary = Salary;
            this.DepartmentId = DepartmentId;
            this.City = city;
        }
    }
    public class Employee2
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public string City { get; set; }

        public Employee2(int EmployeeID, string Name, double Salary, string department, string city)
        {
            this.EmployeeID = EmployeeID;
            this.Name = Name;
            this.Salary = Salary;
            this.Department = department;
            this.City = city;
        }
    }


    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department(int Id, string name)
        {
            this.Id = Id;
            this.Name = name;
        }
    }
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public Student(int rollNo, string name, int marks)
        {
            RollNo = rollNo;
            Name = name;
            Marks = marks;
        }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public Order(int orderId, string customerName, List<OrderItem> orderItems)
        {
            OrderId = orderId;
            CustomerName = customerName;
            OrderItems = orderItems;
        }
    }
    public class OrderItem
    {
        public string ProductName;
        public double Price;

        public OrderItem(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }
    }
}
