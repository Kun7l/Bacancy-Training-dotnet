using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Services
{
    public class Queries
    {
        #region Task1
        public void Task1(List<Employee> employees,List<Department> departments)
        {
            var highestSalary = employees.Max(e => e.Salary);
            
            var lowestSalary = employees.Min(e=> e.Salary);

            var totalSalary = employees.Sum(e=> e.Salary);

            var avgSalary = employees.Average(e=>e.Salary);

            var departmentEmployees = from emp in employees
                                      join dept in departments
                                      on emp.DepartmentId equals dept.Id
                                        group dept by dept.Name into grp
                                        select  new {DeptName = grp.Key, EmpCount = grp.Count()}
                                      ;

            
                                         
            Console.WriteLine($"Highest salary : {highestSalary}, Lowest Salary : {lowestSalary}, Total Salary {totalSalary}, Average Salary {avgSalary}");
            Console.WriteLine();
            foreach (var e in departmentEmployees) {
                Console.WriteLine(e);
            }
        }

        /* Thoery : 
         * LINQ features used : Aggregate functions (Max, Min, Sum, Average), join, group by, select
         * Max : used to find the maximum value from column
         * Min : used to find the minimum value from column
         * Sum : used to add all the values from column
         * Average : used to count average of all the values in column
         * join : join keyword represents inner join which fetched common records from two tables
         * select : select is used for projection on the output.
         */
        #endregion

        #region Task2
        public void Task2(List<Employee> employees,List<Department> departments)
        {
            var employeeWithDepartmentName = from emp in employees
                                             join dept in departments
                                             on emp.DepartmentId equals dept.Id
                                             select new { Name = emp.Name, DeptName = dept.Name };

            var departmentEmployees = from dept in departments
                                      join emp in employees
                                      on dept.Id equals emp.DepartmentId into empGroup
                                      select new { DeptName = dept.Name, EMp = empGroup}
                                     ;
            foreach (var item in employeeWithDepartmentName)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in departmentEmployees) {
                Console.WriteLine(item.DeptName + " : ");
                foreach (var item1 in item.EMp)
                {
                    Console.WriteLine(item1.Name);
                }
                Console.WriteLine();
            }
        }

        /* Thoery : 
       * LINQ features used : join, group by, select
       * join : join keyword represents inner join which fetched common records from two tables
       * select : select is used for projection on the output.
       */
        #endregion

        #region Task3
        public void Task3(List<Employee> employees,List<Department> departments)
        {
            var departmentEmployees = from emp in employees
                                      join dept in departments
                                      on emp.DepartmentId equals dept.Id
                                      group emp by dept.Name into grp
                                      select new { DeptName = grp.Key ,EmpCount = grp.Count(), AvgSalary = grp.Average(g=>g.Salary) }
                          ;
            foreach (var item in departmentEmployees) { Console.WriteLine(item); }

        }

        /* Thoery : 
        * LINQ features used : join, group by, select
        * join : join keyword represents inner join which fetched common records from two tables
        * select : select is used for projection on the output.
        * group by : group by is used to group rows with given column.
        */
        #endregion

        #region Task4
        public void Task4(List<Employee> employees, List<Department> departments)
        {
            var greaterSalaryThenAvg = employees.Where(e => e.Salary > employees.Average(e => e.Salary)).Select(e => new { Name = e.Name, Salary = e.Salary });

            var hrSalary = from emp in employees
                                  join dept in departments
                                  on emp.DepartmentId equals dept.Id
                                  where dept.Name == "HR"
                                  select emp.Salary;
            var highestHR = hrSalary.Max();

            var employeesHighThenHRSalary = employees.Where(e=>e.Salary > highestHR).Select(e => new { Name = e.Name,Salary = e.Salary });

            Console.WriteLine(highestHR);
           foreach(var item in employeesHighThenHRSalary)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(employees.Average(e => e.Salary));
            foreach(var item in greaterSalaryThenAvg) { Console.WriteLine(item); }
        }

        #endregion

        #region Task-5
        public void Task5(List<int> list1, List<int> list2)
        {
            var commonInList = list1.Intersect(list2);

            var inFirstButNotinSecond = list1.Except(list2);

            var combineBoth = list1.Union(list1);

            Console.WriteLine("Common in both");
            foreach (var item in commonInList)
            {
                Console.WriteLine(item);   
            }
            Console.WriteLine();
            Console.WriteLine("Elmenets in first but not in second");
            foreach (var item in inFirstButNotinSecond)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Combine both and remove duplicates");
            foreach (var item in combineBoth)
            {
                Console.WriteLine(item);
            }

        }
        #endregion
    }
}
