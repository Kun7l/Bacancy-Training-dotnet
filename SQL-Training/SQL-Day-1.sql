INSERT INTO [dbo].[Employee] 
    ([EmployeeID], [FirstName], [LastName], [Email], [Department], [Salary], [DateOfJoining])
VALUES 
(22, 'Charvin', 'Khairanar', 'ck@company.com', 'HR', 75000.00, '2012-01-24');

-- 1. 
select top 5 * from Employee
order by Salary desc;

-- 2.
select distinct Department from Employee
where Department like 'S%';

-- 3. 
select * from Employee
where Department in ('HR','IT','Finanace') and Salary> 50000;

-- 4.
select * from Employee
where Department = 'Sales' or Salary>75000;

-- 5. 
select * from Employee
where Email like '%' + FirstName + '%';

-- 6. 
select * from Employee
order by DateOfJoining
offset 5 rows
fetch next 5 rows only
;

-- 7.
select * from Employee
where (Department = 'IT' and Salary> 60000) or (Department = 'HR' and DateOfJoining < '2020-01-01')
;