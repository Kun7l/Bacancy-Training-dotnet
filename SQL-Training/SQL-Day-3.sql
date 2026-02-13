--1.

create function dbo.getExperience(@DateOfJoining date)
returns decimal
as
begin
 return round( datediff(MONTH,@DateOfJoining,getdate())/12,1);
end;

go

select FirstName,DateOfJoining, Experience = dbo.getExperience(DateOfJoining) from employee;

go 

--2.

create function isSeniorEmployee (@DepartmentId varchar(50))
returns table
as 
return (select * , IsSeniorEmployee = iif(dbo.getExperience(DateOfJoining) > 5 ,'Yes','No')
from Employee
where Department = @DepartmentId
);

go

select * from dbo.isSeniorEmployee(4);

go

--3.

create procedure dbo.ChangeDept @EmployeeId int, @NewDept int
as 
begin

update Employee
set Department = @NewDept
where EmployeeID = @EmployeeId
;
end;

go

CREATE PROCEDURE dbo.NewEmployee 
    @EmployeeId int, 
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @DepartmentId int,
    @DepartmentName VARCHAR(50),
    @Salary DECIMAL(10,2),
    @DateOfJoining DATE
AS
BEGIN 
    BEGIN TRY
        
        INSERT INTO Employee (
            EmployeeId, FirstName, LastName, Email, 
            Department, DepartmentName, Salary, DateOfJoining
        )
        VALUES (
            @EmployeeId, @FirstName, @LastName, @Email, 
            @DepartmentId, @DepartmentName, @Salary, @DateOfJoining
        );
    END TRY
    BEGIN CATCH
        THROW; 
    END CATCH
END;
GO

exec dbo.NewEmployee @EmployeeId = 22, @firstName = 'Krunal', @LastName = 'Khairanar', @email = 'varun.aggarwal@coompany.com', @departmentid = 3, @departmentName = 'IT',@salary = 70000, @Dateofjoining = '2020-01-01';


create function dbo.calculateTenureSalary (
    @EmpId int,
    @StartDate date,
    @EndDate date
)
returns decimal(18,2)
as 
begin 
    declare @Result decimal(18,2);

    select @Result = (
        iif(DateOfJoining>@EndDate,0,DATEDIFF(month, @StartDate, @EndDate) - 
        iif(DATEDIFF(month, @StartDate, DateOfJoining) < 0, 0, DATEDIFF(month, @StartDate, DateOfJoining)))
    ) * Salary
    from Employee
    where EmployeeID = @EmpId;

    return @Result;
end;


go

create procedure dbo.CalculateDeptSalary @StartDate date, @EndDate date
as
begin 
select DepartmentName, TotalSalaryEarned = Sum( dbo.calculateTenureSalary(EmployeeId,@StartDate,@EndDate))
from Employee
group by DepartmentName

end;

go

exec dbo.CalculateDeptSalary @StartDate = '2020-01-01', @EndDate = '2025-01-01';

create table Orders (
OrderId int,
ProductId int,
CustomerName varchar(50),
OrderStatus Bit
);
create table Products (
ProductId int,
ProductName varchar(20),
Price decimal
);

create table OrderAudit (
OrderId int,
InsertDate date,
InsertedBy varchar(50)
);
go

create trigger orderInsertTrigger
on Orders
after insert 
as
begin

insert into OrderAudit (OrderId,InsertDate,InsertedBy)
select OrderId,GETDATE(),CustomerName
from inserted;

end;

insert into Orders 
values (1,1,'rahul',1);

select * from Orders;
select * from OrderAudit;

go

create trigger checkActiveOrder
on Products
after delete
as 
	begin
		if exists (select 1 
		from deleted d
		join Orders o on o.ProductId = d.ProductId
		where o.OrderStatus = 1
		)
	begin 
		print 'Cannot delete products in active orders'
		rollback transaction;
		end

end;

delete from Products
where ProductId = 1;

select * from Products;
select * from Orders;