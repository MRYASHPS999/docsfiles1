create table auth(

	id int primary key identity,
	email varchar(100),
	username varchar(100),
	password varchar(100),
	role varchar(100)

);

create proc InsertUser
	@email varchar(100),
	@username varchar(100),
	@password varchar(100)
as
begin
	insert into auth values(@email,@username,@password);
end
