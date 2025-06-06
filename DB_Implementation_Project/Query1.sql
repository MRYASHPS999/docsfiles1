create  table employee(

  id int primary key identity,
  name varchar(100),
  email varchar(100),
  dept varchar(100),
  salary decimal(9,2)

);

create proc SaveEmp
	@name varchar(100),
    @email varchar(100),
	@dept varchar(100),
	@salary decimal(9,2)
as
begin
	insert into employee values(@name,@email,@dept,@salary);
end

create proc FetchEmp
as
begin
	select * from employee;
end

create proc DeleteEmp
 @id int
as
begin
  delete from employee where id = @id;
end

create proc SearchEmp
@name varchar(100)
as
begin
 select * from employee where name like '%@name%';
end

create proc UpdateEmp
	@id int,
	@name varchar(100),
    @email varchar(100),
	@dept varchar(100),
	@salary decimal(9,2)
as
begin
 update employee set name=@name,email=@email,dept=@dept,salary=@salary where id=@id;
end



select * from employee;