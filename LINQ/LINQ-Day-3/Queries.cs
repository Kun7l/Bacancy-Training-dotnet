using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LINQ_Day_3
{
    internal class Queries
    {
        #region Task1
        public void Task1(List<Employee> employees, List<Department> departments)
        {
            var moreThanThirty = employees.Where(e => e.Salary > 30000).ToList();

            employees.Add(new Employee(7, "Vishal", 50000, 1, "Valsad"));

            foreach (var employee in moreThanThirty)
            {
                Console.WriteLine($"Name : {employee.Name} -- Salary : {employee.Salary}");
            }
        }
        /* 
         Theory : 
         The query runs differed execution because the query doesnt get executed initialy,but after using for each which forces the execution of query. Resulting the 50000 salary employee added in result.
         */
        #endregion

        #region Task2
        public void Task2(List<Student> students)
        {
            var marksGreaterThanForty = students.Where(s => s.Marks > 40).ToList();
            students[0].Marks = 80;

            var newQuery = students.Where(s => s.Marks > 40);

            foreach(var student in marksGreaterThanForty)
            {
                Console.WriteLine($"Name : {student.Name} -- Marks : {student.Marks}");
            }
            Console.WriteLine();
            foreach (var student in newQuery)
            {
                Console.WriteLine($"Name : {student.Name} -- Marks : {student.Marks}");
            }

            /*
             Theory : 
              immidiate execution is achieved via methods like (toList(), foreach loop etc). Which forces query to execute while using.
               Differed execution happens when query is writen and then when it's needed then only the execution happens, which prevents unnecessary db calls.
             */

        }
        #endregion

        #region Task3
        public void Task3(List<Order> orders)
        {
            var allProductNames = orders.SelectMany(o => o.OrderItems).Select(p => p.ProductName);
            var ProductNamesWithoutDuplicateValues = allProductNames.Distinct();
            var countSales = allProductNames.Count();


            foreach( var order in ProductNamesWithoutDuplicateValues)
            {
                Console.WriteLine(order);
            }
            Console.WriteLine();
            Console.WriteLine("Total number of products sold : " + countSales);
        }
        /* Theory : 
         * We have a list of orders and inside that list we have orderItems, which is now a 2D list. to get acess of inside list select is not sufficient. We have to flatten the list using selectMany.
         * and then get access to order items.
         */
        #endregion

        #region Task4
        public void Task4(List<Employee> employees,List<Department> departments)
        {
            var employeesWithDept = from dept in departments
                                    join emp in employees
                                    on dept.Id equals emp.DepartmentId into EmpGrp
                                    select new { Name = dept.Name, empCount = EmpGrp.Count() };
            foreach (var item in employeesWithDept)
            {
                Console.WriteLine(item.Name +" "+ item.empCount);
            }
        }
        /* Thoery : 
         * Deferred execution is used here because LINQ queries are executed only when iterated in foreach. 
         * immidiate execution happens when we use methods like toString(), Count(), First() etc.
         * */
        #endregion

        #region Task5
        public void Task5(List<Employee> employees, List<Department> departments)
        {
            IEnumerable<Employee> empEnumerable = employees
            .Where(e => e.Salary > 30000);

            Console.WriteLine("IEnumerable Result:");
            foreach (var emp in empEnumerable)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.Name} {emp.Salary} {emp.DepartmentId}");
            }
            IQueryable<Employee> empQueryable = employees
                .AsQueryable()
                .Where(e => e.Salary > 30000);

            Console.WriteLine("\nIQueryable Result:");
            foreach (var emp in empQueryable)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.Name} {emp.Salary} {emp.DepartmentId}");
            }

        }
        /* Theory:
         
            IEnumerable

            Works with data already loaded in memory
            Filtering happens after fetching all data
            Uses LINQ to Objects 
        
            IQueryable

            Works with database or external data source
            Filtering happens before data is fetched
            Converts LINQ into SQL query
            More efficient for large data
         */
        #endregion

        #region Task6
        public void Task6(List<Employee> employees, List<Department> departments)
        {
            var wrongWay = from emp in employees
                           select new
                           {
                               Name = emp.Name,
                               Dept = (from dept in departments
                                       where dept.Id == emp.DepartmentId
                                       select dept.Name).First()
                           };

            var rightWay = from emp in employees
                           join dept in departments
                           on emp.DepartmentId equals dept.Id
                           select new { Name = emp.Name, Dept = dept.Name };

            Console.WriteLine("N+1 problem query");
            foreach (var emp in wrongWay)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine();
            Console.WriteLine("Correct query");
            foreach (var emp in rightWay) {
                Console.WriteLine(emp);
            }
        }
        /* Thoery :
         * N+1 problem basically occurs when we fetch a initial (Main) query and while looping through it we trigger a separate query to get related data.
         * 1 - inital query for N rows.
         * N - subquery for each row.
         * 
         * N+1 problem is bad because of unneccessary db calls affect performance of the application. Resources like Memory are used unnecessarily.
         * Each query suffers network overhead and database processing time.
         */
        #endregion

        #region Task7
        public void Task7(List<Order> orders)
        {
            var withDuplicate = orders.SelectMany(o => o.OrderItems).Select(p => p.ProductName);
            var withoutDuplicates = withDuplicate.Distinct();


            Console.WriteLine("With Duplicates :");
            foreach (var order in withDuplicate)
            {
                Console.WriteLine(order);
            }
            Console.WriteLine();
            Console.WriteLine("Without Duplicates :");
            foreach (var order in withoutDuplicates)
            {
                Console.WriteLine(order);
            }

        }

        /* Thoery : 
         * SelectMany : Each Order contains a collection of OrderItems. If you used a regular Select, you would end up with a list of lists. SelectMany flattens the list to get 1D list.
         * Select : Once we flattened the list, to get acess of ProductName we use select.
         * Distinct : Distinct is used to eliminate duplicate values.
         */

        #endregion

        #region Task8
        public void Task8(List<Employee> employees)
        {
            Dictionary<int, string> employeeDictionary;

            employeeDictionary = employees.ToDictionary(e=>e.EmployeeID,e=>e.Name);
            foreach (var item in employeeDictionary)
            {
                Console.WriteLine(item.Key + " "+ item.Value);
            }

        }

        #endregion

        #region Task9
        public void Task9(List<Employee2> employees)
        {
            var itEmployees = employees.Where(e => e.Department == "IT");

            Console.WriteLine("----- Before change -----");
            foreach (var employee in itEmployees) {
                Console.WriteLine(employee.Name + " "+employee.Department);
            }

            employees[0].Department = "HR";

            Console.WriteLine();
            Console.WriteLine("----- After change -----");
            foreach (var employee in itEmployees)
            {
                Console.WriteLine(employee.Name + " " + employee.Department);
            }
        }
        #endregion
    }
}
