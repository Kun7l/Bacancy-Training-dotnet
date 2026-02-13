create table Departments (
DepartmentId int primary key,
DepartmentName varchar(50) not null unique
);

create table Employees (
EmployeeId int primary key,
Name varchar(50) not null,
Salary decimal check (Salary > 15000.0),
HireDate date,
DepartmentId int references Departments(DepartmentId)
);

Insert into Departments
values (1,'IT'),(2,'HR'),(3,'Finance'),(4,'Sales'),(5,'Marketing');

alter table Employees
add Email varchar(50) unique;

alter table Employees 
add isActive bit default 1;

alter table Employees
alter column Salary decimal(12,2);

alter table Employees
add Constraint chk_HireDate check (HireDate <= getDate());



INSERT INTO Employees (EmployeeId, Name, Salary, HireDate, DepartmentId, Email)
VALUES 
(5, 'rahil', 25000.0, '2024-01-15', 1, 'rahil@company.com'),
(6, 'Ananya', 32000.5, '2023-11-20', 1, 'ananya@company.com'),
(7, 'Rohan', 18500.0, '2024-02-01', 2, 'rohan@company.com'),
(8, 'Priya', 45000.0, '2022-05-10', 3, 'priya@company.com'),
(9, 'Arjun', 22000.0, '2023-08-15', 4, 'arjun@company.com'),
(10, 'Sneha', 27500.0, '2024-01-10', 5, 'sneha@company.com'),
(11, 'Vikram', 19000.0, '2023-12-01', 3, 'vikram@company.com'),
(12, 'Kabir', 31000.0, '2023-06-25', 4, 'kabir@company.com');


update Employees
set Salary = Salary*1.05;

update Employees
set isActive = 0
where HireDate < '2024-01-01';

Delete Employees
where isActive = 0;

update Employees
set DepartmentId = 2
where EmployeeId in (2,3);

select Name,DepartmentName from Employees emp
join Departments dept 
on emp.DepartmentId = dept.DepartmentId;

SELECT dept.DepartmentName
FROM Departments dept
LEFT JOIN Employees emp ON dept.DepartmentId = emp.DepartmentId
WHERE emp.EmployeeId IS NULL;

select d.DepartmentName, e.Name, e.Salary from Employees e
join Departments d 
on e.DepartmentId = d.DepartmentId
where e.Salary = (
select max(Salary) from Employees
where DepartmentId = d.DepartmentId
);