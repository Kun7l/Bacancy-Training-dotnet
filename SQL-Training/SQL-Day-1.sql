CREATE DATABASE [SQL-Training];
GO

USE [SQL-Training];

CREATE TABLE Employee
(
 	EmployeeID INT,
 	FirstName VARCHAR(50),
 	LastName VARCHAR(50),
 	Email VARCHAR(100),
 	Department VARCHAR(50),
 	Salary DECIMAL(10,2),
 	DateOfJoining DATE
 );

INSERT INTO Employee 
    ([EmployeeID], [FirstName], [LastName], [Email], [Department], [Salary], [DateOfJoining])
VALUES 
(1, 'Arjun', 'Mehta', 'arjun.mehta@company.com', 'IT', 75000.00, '2023-01-15'),
(2, 'Priya', 'Sharma', 'priya.sharma@company.com', 'HR', 62000.00, '2022-05-22'),
(3, 'Rohan', 'Patel', 'rohan.patel@company.com', 'Finance', 68000.00, '2021-11-01'),
(4, 'Ananya', 'Iyer', 'ananya.iyer@company.com', 'Marketing', 55000.00, '2023-03-10'),
(5, 'Kabir', 'Singh', 'kabir.singh@company.com', 'IT', 82000.00, '2022-07-19'),
(6, 'Ishani', 'Verma', 'ishani.verma@company.com', 'Operations', 59000.00, '2021-11-25'),
(7, 'Vikram', 'Nair', 'vikram.nair@company.com', 'Finance', 71000.00, '2020-02-14'),
(8, 'Sana', 'Khan', 'sana.khan@company.com', 'IT', 77000.00, '2023-06-30'),
(9, 'Amit', 'Gupta', 'amit.gupta@company.com', 'Sales', 52000.00, '2019-09-05'),
(10, 'Riya', 'Das', 'riya.das@company.com', 'HR', 60000.00, '2024-01-12'),
(11, 'Aditya', 'Joshi', 'aditya.joshi@company.com', 'Marketing', 56000.00, '2022-04-20'),
(12, 'Meera', 'Reddy', 'meera.reddy@company.com', 'Operations', 64000.00, '2020-10-18'),
(13, 'Yash', 'Chopra', 'yash.chopra@company.com', 'Sales', 53000.00, '2021-05-22'),
(14, 'Tara', 'Malhotra', 'tara.malhotra@company.com', 'IT', 79000.00, '2023-08-08'),
(15, 'Zane', 'Dsouza', 'zane.dsouza@company.com', 'Finance', 69000.00, '2022-12-14'),
(16, 'Kavya', 'Bose', 'kavya.bose@company.com', 'HR', 61000.00, '2021-02-27'),
(17, 'Sahil', 'Pandey', 'sahil.pandey@company.com', 'Marketing', 57000.00, '2018-07-03'),
(18, 'Nora', 'Fernandes', 'nora.fernandes@company.com', 'Operations', 65000.00, '2023-11-11'),
(19, 'Varun', 'Mishra', 'varun.mishra@company.com', 'IT', 81000.00, '2022-03-25'),
(20, 'Diya', 'Saxena', 'diya.saxena@company.com', 'Sales', 54000.00, '2024-09-09'),
(21, 'Krnal', 'Khairanar', 'kk@company.com', 'HR', 75000.00, '2005-01-24'),
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