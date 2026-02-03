using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Services
{
    
    public class LINQ_Assignment
    {
        // LINQ Syntax : Method type

        #region Task-1
        public void Task1(List<Employee> list)
        {
            var result = list.Where(emp => emp.Salary > 25000).Select(emp => new { ID = emp.EmployeeID, Name = emp.Name, Salary = emp.Salary });

            foreach (var e in result)
            {
                Console.WriteLine(e);
            }
        }
        /* Theory : 
        * LINQ features used are : where
        * where clause is used to do filteration from collection or db using specific conditions 
        */
        #endregion

        #region Task-2
        public void Task2(List<Employee> list)
        {
            var result = list.Where(emp => emp.Department == "IT").Select(emp => new { emp.EmployeeID, emp.Name, emp.Salary, emp.Department });

            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.Name} {emp.Salary} {emp.Department}");
            }
        }
        /* Theory : 
         * LINQ features used are : where, .toList()
         * where clause is used to do filteration from collection or db using specific conditions 
         * select keyword is used for projection.
         * toList() is used to convert its arguments to a List value
       */
        #endregion

        #region Task-3
        public void Task3(List<Employee> list)
        {
            var result = list.Where(e => e.Salary > 30000).OrderByDescending(e => e.Salary).Select(e => new { e.EmployeeID, e.Name, e.Salary });

            foreach (var e in result)
            {
                Console.WriteLine(e);
            }
        }
        /* Theory : 
         * LINQ features used are : where, select, orderbydescending
         * where clause is used to do filteration from collection or db using specific conditions 
         * select keyword is used for projection.
         * OrderByDescending is used for order the rows with perticular fields in descending order
       */
        #endregion

        #region Task-4
        public void Task4(List<Employee> list)
        {
            var result = list.Select(e => new { e.EmployeeID, e.Name, e.Department }).OrderBy(e => e.Department).ThenBy(e => e.Name);

            foreach(var e in result)
            {
                Console.WriteLine(e);
            }
        }
        /* Theory : 
         * LINQ features used are : select, orderby, thenby
         * select keyword is used for projection.
         * OrderBy is used for order the rows with perticular fields
         * thenby works after orderby in same manner
       */
        #endregion

        #region Task-5
        public void Task5(List<Student> students)
        {
            var res = students.Select(s => new { s.RollNo, s.Name, s.Marks, Result = s.Marks > 50 ? "Pass" : "Fail" });

            foreach(var s in res)
            {
                Console.WriteLine(s);
            }
            
        }
        /* Theory : 
         * LINQ features used are : select.
         * select keyword is used for projection.
         * New field is Result is used to save the data of passed and failed students, it is created using new keyword in slecet. 
            ternary is used as an if else block
       */
        #endregion

        #region Task-6
        public void Task6(List<Employee> list)
        {
            var result = list.Select(e => new { e.Name,e.Department,e.City});
            foreach(var e in result)
            {
                Console.WriteLine(e);
            }
        }
        /* Theory : 
         * LINQ features used are : select.
         * select keyword is used for projection.
       */
        #endregion

        #region Task-7
        public void Task7(List<Order> orders)
        {
            var result = orders.SelectMany(s => s.OrderItems).Select(item => item.ProductName);
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
        /* Theory : 
         * LINQ features used are : select.
         * select keyword is used for projection.
       */
        #endregion

        #region Task-8
        public void Task8(List<Order> orders)
        {
            var result = orders.Select(o =>
            new
            {
                CustomerName = o.CustomerName,
                Orders = o.OrderItems.Select(item => new { item.ProductName })

            });
            foreach(var item in result)
            {
                Console.WriteLine(item.CustomerName);
               foreach(var o in item.Orders)
                {
                    Console.WriteLine(o);
                }
                Console.WriteLine();
            }
        }
        /* Theory : 
         * LINQ features used are : select.
         * select keyword is used for projection.
         * Data needed to be flattened because Order items need to be in one dimention array, before flattening it was in two dimention.
       */
        #endregion

        #region Task-9
        public List<string> Task9(List<Employee> list)
        {
            return list.Select(e => e.Name).ToList();
        }
        /* Theory : 
         * LINQ features used are : select.
         * select keyword is used for projection.
       */
        #endregion

        #region Task-10
        //using method syntax
        public void Task10(List<Employee> list)
        {
            var result = list.Where(e => e.Salary > 25000);
            var result1 = from e in list
                          where e.Salary > 25000
                          select e;

        }
        /* Theory : 
        *  query syntax is more readable and concise. In others, method syntax is more readable. There's no semantic or performance difference between the two different forms
      */
        #endregion
    }
}
