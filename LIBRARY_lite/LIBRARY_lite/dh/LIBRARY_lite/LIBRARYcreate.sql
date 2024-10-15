--create database LIBRARYCP_updated;

use LIBRARYCP_updated;

create table ROLES ( /*роли сотрудников, от которых зависят их права*/
	RoleID int identity not null,
	RoleName nvarchar(250) not null,
	primary key (RoleID)
)

insert into ROLES (RoleName) values ('Администратор'), ('Библиотекарь')

create table EMPLOYEES ( /*список сотрудников с данными для авторизации*/
	EmployeeID int identity not null,
	EmployeeName nvarchar(max) not null,
	EmployeeRole int not null,
	IsWorking bit not null,
	primary key (EmployeeID),
	foreign key (EmployeeRole) references ROLES(RoleID)
)

create table USERS (
	UserID int identity not null,
	EmployeeID int not null,
	ULogin nvarchar(20) not null,
	UPassword nvarchar(20) not null,
	primary key (UserID),
	foreign key (EmployeeID) references EMPLOYEES(EmployeeID)
)

create table READERS (
	ReaderID int identity not null,
	ReaderName nvarchar(max) not null,
	BirthDate datetime not null,
	PhoneNumber nvarchar(11) not null,
	primary key (ReaderID)
)

create table AUTHORS (
	AuthorID int identity not null,
	AuthorName nvarchar(max) not null,
	primary key (AuthorID)
)

insert into AUTHORS (AuthorName) values ('Неизвестно')

create table PUBLISHERS (
	PublisherID int identity not null,
	PublisherName nvarchar(max) not null,
	primary key (PublisherID)
)

insert into PUBLISHERS (PublisherName) values ('Неизвестно')

create table BOOKS (
	ISBN nvarchar(13) not null,
	BookName nvarchar(max) not null,
	BookAuthor int not null,
	Publisher int not null,
	PublDate nvarchar(4) not null,
	primary key(ISBN),
	foreign key(BookAuthor) references AUTHORS(AuthorID),
	foreign key(Publisher) references PUBLISHERS(PublisherID)
)

create table INSTANCES (
	InstanceID int identity not null,
	ISBN nvarchar(13) not null,
	IsTaken bit not null,
	primary key (InstanceID),
	foreign key (ISBN) references BOOKS(ISBN)
)

create table INSTANCE_SETS (
	InstanceSetID int identity not null,
	primary key (InstanceSetID)
)

create table INSTANCE_SET_CONTENTS (
	InstanceSetContentID int identity not null,
	InstanceSetID int not null,
	InstanceID int not null,
	ReturnDate date,
	primary key(InstanceSetContentID),
	foreign key (InstanceSetID) references INSTANCE_SETS(InstanceSetID),
	foreign key (InstanceID) references INSTANCES(InstanceID)
)

create table BOOK_LEND (
	BookLendID int identity not null,
	ReaderID int not null,
	InstanceSetID int not null,
	LendDate date not null,
	ExpReturnDate date not null,
	ActReturnDate date,
	Prolongated int not null,
	primary key (BookLendID),
	foreign key (ReaderID) references READERS(ReaderID),
	foreign key (InstanceSetID) references INSTANCE_SETS(InstanceSetID)
)