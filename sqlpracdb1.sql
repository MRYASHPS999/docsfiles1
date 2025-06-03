create database sqldbprac;

create table emp
(
 id int primary key identity,
 name varchar(100),
 salary decimal(9,2)
);


create table emplogs
(
  id int primary key identity,
  name varchar(100),
  salary decimal(9,2),
  createdAt varchar(100)
);

create trigger InsertTrigger
on emp
after insert 
as
begin
print 'Employee created successfully';
end


create trigger InsertTrigger1
on emp
after insert
as
begin
 insert into emplogs select name,salary,getdate() from inserted; 
end

create trigger UpdateTrigger
on emp
after update
as
begin

 declare @Name varchar(100);
 declare @Id int;
 select @Id=id,@Name=name from inserted;
 update emplogs set name=@Name where id=@Id;

end

create trigger DeleteTrigger1
on emp
after delete
as
begin
  declare @Id int;
  select @Id=id from deleted;
  delete from emplogs where id=@Id;
end

delete from emp where id=4;

update emp set name='Jigar' where id=1;


insert into emp values('John s',6200.78);

select * from emp;
select * from emplogs;

truncate table emp;

======================================================

//instead of trigger

create trigger BeforeInsert
on emp
instead of insert
as
begin
  declare @Salary decimal(9,2);
  select @Salary=salary from inserted;
  if(@Salary>5000)
   begin
    insert into emp select name,salary from inserted;
   end
  else
   begin
    print 'Salary Should be more than 5000';
   end
end

