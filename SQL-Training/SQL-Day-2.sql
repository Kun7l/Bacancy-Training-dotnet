use [SQL-Training];

create table Employee
(
 	EmployeeID INT NOT NULL,
 	FirstName VARCHAR(50),
 	LastName VARCHAR(50),
 	Email VARCHAR(100),
 	Department INT NOT NULL,
    DepartmentName varchar(50),
 	Salary DECIMAL(10,2),
 	DateOfJoining DATE
);
create table Department (
deptId INT,
deptName varchar(50)
);
insert into Department
values (1,'HR'),(2,'Finance'),(3,'IT'),(4,'Marketing');

insert into Employee
(EmployeeID, FirstName, LastName, Email, Department, DepartmentName, Salary, DateOfJoining)
values
(1,'Rahul','Sharma','rahul.sharma@company.com',1,'HR',45000,'2021-01-15'),
(2,'Amit','Patel','amit.patel@company.com',2,'Finance',52000,'2020-03-20'),
(3,'Neha','Verma','neha.verma@company.com',1,'HR',48000,'2022-07-10'),
(4,'Karan','Mehta','karan.mehta@company.com',3,'IT',61000,'2019-11-05'),
(5,'Pooja','Singh','pooja.singh@company.com',2,'Finance',55000,'2021-06-12'),
(6,'Rohit','Yadav','rohit.yadav@company.com',4,'Marketing',47000,'2023-02-01'),
(7,'Sneha','Joshi','sneha.joshi@company.com',1,'HR',53000,'2020-09-18'),
(8,'Vikas','Nair','vikas.nair@company.com',3,'IT',62000,'2018-12-25'),
(9,'Anjali','Gupta','anjali.gupta@company.com',2,'Finance',51000,'2022-01-03'),
(10,'Deepak','Kumar','deepak.kumar@company.com',4,'Marketing',46000,'2021-04-19'),
(11,'Priya','Desai','priya.desai@company.com',1,'HR',58000,'2019-07-11'),
(12,'Arjun','Kapoor','arjun.kapoor@company.com',3,'IT',64000,'2017-05-14'),
(13,'Riya','Chauhan','riya.chauhan@company.com',2,'Finance',49500,'2023-03-30'),
(14,'Manish','Reddy','manish.reddy@company.com',4,'Marketing',47000,'2020-10-21'),
(15,'Kavita','Iyer','kavita.iyer@company.com',1,'HR',60000,'2018-08-09'),
(16,'Nikhil','Bansal','nikhil.bansal@company.com',3,'IT',72000,'2016-01-01'),
(17,'Sonal','Malhotra','sonal.malhotra@company.com',2,'Finance',54000,'2021-11-13'),
(18,'Ajay','Shah','ajay.shah@company.com',4,'Marketing',45000,'2022-05-27'),
(19,'Meera','Trivedi','meera.trivedi@company.com',1,'HR',67000,'2019-03-15'),
(20,'Varun','Aggarwal','varun.aggarwal@company.com',3,'IT',71000,'2017-09-07');

go

-- 1.
create view vw_EmployeeBasicInfo as
select EmployeeID,FirstName,LastName,Department from Employee;
go
select * from vw_EmployeeBasicInfo;


--2. 
with myCTE as 
(
select * from Employee
where DepartmentName = 'Finance'
)
select * from myCTE;

--3.
select *
into #HrDeptEmployee
from Employee 
where DepartmentName = 'HR';

select * from #HrDeptEmployee;


--4.
create table EmployeeSkill(
EmployeeID INT,
SkillName varchar(20)
);

insert into EmployeeSkill
values (5,'coding'),(1,'running'),(3,'singing'),(1,'dancing'),(2,'singing'),(2,'dancing'),(3,'coding'),(4,'coding');

with multipleSkillCount as (
select EmployeeID
from EmployeeSkill
group by EmployeeID
having count(SkillName) > 1
)
select * from Employee
where EmployeeID in (select EmployeeID from multipleSkillCount);

--5.
alter table Employee add primary key (EmployeeId);
alter table Employee add constraint FK_Dept foreign key (Department) references Department (deptId);
alter table Employee add constraint Unique_email unique (Email);
