--delete from BOOK_LEND;
--delete from INSTANCE_SET_CONTENTS;
--delete from INSTANCE_SETS;
--delete from INSTANCES;
--DELETE from BOOKS;
--delete from AUTHORS;
--delete from PUBLISHERS;
--delete from READERS;
--delete from EMPLOYEES;
--delete from ROLES;

--create database library;
use library;
create table ROLES (
	RoleID int identity not null,
	RoleName nvarchar(20) not null,
	primary key(RoleID)
)
insert into ROLES (RoleName) values ('Администратор'), ('Библиотекарь')
create table EMPLOYEES (
	EmployeeID int identity not null,
	EmployeeName nvarchar (100) not null,
	RoleID int not null,
	IsWorking bit not null,
	ELogin nvarchar (20) not null,
	EPassword nvarchar(20) not null,
	primary key (EmployeeID),
	foreign key (RoleID) references ROLES(RoleID)
)
create table READERS (
	ReaderID int identity not null,
	ReaderName nvarchar(100) not null,
	BirthDate datetime not null,
	PhoneNumber nvarchar(10) not null,
	IsReading bit not null,
	primary key (ReaderID)
)
create table AUTHORS (
	AuthorID int identity not null,
	AuthorName nvarchar (250) not null,
	primary key(AuthorID)
)
create table PUBLISHERS (
	PublisherID int identity not null,
	PublisherName nvarchar (250) not null,
	primary key(PublisherID)
)
create table BOOKS (
	BookID int identity not null,
	ISBN nvarchar (13) not null,
	BookName nvarchar (250) not null,
	AuthorID int not null,
	PublisherID int not null,
	PublDate int not null,
	IsTaken bit not null,
	Quantity int not null,
	primary key(BookID),
	foreign key (AuthorID) references AUTHORS(AuthorID),
	foreign key (PublisherID) references PUBLISHERS(PublisherID)
)
create table BOOK_SETS (
	BookSetID int identity not null,
	BookSetName nvarchar(25) not null,
	primary key (BookSetID)
)
create table BOOK_SET_CONTENTS (
	BookSetContentID int identity not null,
	BookSetID int not null,
	BookID int not null,
	ReturnDate datetime,
	primary key (BookSetContentID),
	foreign key(BookSetID) references BOOK_SETS(BookSetID),
	foreign key(BookID) references BOOKS(BookID)
)
create table BOOKLEND (
	BookLendID int identity not null,
	ReaderID int not null,
	BookSetID int not null,
	LendDate datetime not null,
	ExpReturnDate datetime not null,
	ActualReturnDate datetime,
	primary key (BookLendID),
	foreign key (ReaderID) references READERS(ReaderID),
	foreign key (BookSetID) references BOOK_SETS(BookSetID)
)
create table LOST_BOOKS (
	LostBookID int identity not null,
	ReaderID int not null,
	BookID int not null,
	LossDate datetime not null,
	primary key(LostBookID),
	foreign key (ReaderID) references READERS (ReaderID),
	foreign key (BookID) references BOOKS(BookID)
)