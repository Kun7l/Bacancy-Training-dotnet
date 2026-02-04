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

        /* Theory :
        * LINQ features used :
        * 1. Max       – Used to find the highest salary from the Salary column.
        * 2. Min       – Used to find the lowest salary from the Salary column.
        * 3. Sum       – Used to calculate the total salary of all employees.
        * 4. Average   – Used to calculate the average salary of employees.
        * 5. Join      – Used to combine Employee and Department data based on DepartmentId.
        * 6. Group By  – Used to group employees by Department name.
        * 7. Select   – Used for projecting the final result with department name and employee count.
        *
        * Why used :
        * Aggregate functions help in performing calculations on numeric data.
        * Join is required to relate employees with their departments.
        * Group By helps in categorizing employees department-wise.
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

        /* Theory :
  * LINQ features used :
  * 1. Join        – Used to fetch employee data along with their department names.
  * 2. Group Join – Used to group employees under their respective departments.
  * 3. Select     – Used to shape the output by selecting required fields.
  *
  * Why used :
  * Join helps in combining data from Employee and Department collections.
  * Group Join helps in creating a hierarchical structure (Department → Employees).
  * Select is used to project only the necessary fields for output.
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

        /* Theory :
        * LINQ features used :
         * 1. Join      – Used to combine Employee and Department collections.
         * 2. Group By  – Used to group employees based on department name.
         * 3. Count     – Used to calculate the number of employees in each department.
         * 4. Average   – Used to calculate average salary per department.
         * 5. Select   – Used to project department name, employee count, and average salary.
         *
         * Why used :
         * Join is required to access department names.
         * Group By helps in department-wise aggregation.
         * Aggregate functions help in calculating summary data per group.
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
        /* Theory :
         * LINQ features used :
         * 1. Where     – Used to filter employees based on salary conditions.
         * 2. Average  – Used to calculate the overall average salary.
         * 3. Join     – Used to filter employees belonging to the HR department.
         * 4. Max      – Used to find the highest salary in the HR department.
         * 5. Select   – Used to project employee name and salary.
         *
         * Why used :
         * Where helps in applying conditional logic.
         * Average and Max help in salary comparison scenarios.
         * Join is required to identify HR department employees.
         */
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
        /* Theory :
         * LINQ features used :
         * 1. Intersect – Used to find common elements between two lists.
         * 2. Except   – Used to find elements present in the first list but not in the second.
         * 3. Union    – Used to combine two lists and remove duplicate values.
         *
         * Why used :
         * Set operators help in performing collection-based comparisons.
         * They provide clean and readable ways to handle list operations.
         */
        #endregion
    }
}
