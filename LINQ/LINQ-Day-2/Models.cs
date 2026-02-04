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

    public class Department 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department(int Id,string name)
        {
            this.Id = Id;
            this.Name = name;
        }
    }

}
