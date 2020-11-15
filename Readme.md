### NHibernate Tasks 1.0

## About
Realy simple program with which I have a lot of fun creating it! You can basically add, modify and remove all tasks you want to do and select which one are alredy done.
There is a lot we can do about this program, but this is first working prototype so I wanted to share it :)

## Installation
1. This app was created using SQL Server 2017 Express. If you want to change that you will have to modify connection string in App.config file.
Default connection string looks like this

        Server=localhost\SQLEXPRESS;initial catalog=test_db;Integrated Security=True

2. In this version, table in database will not create automatically so you will have to create database f.e. test_db or other (remember to change connection string) and Task table as below:
```sql
	create table Task(
		Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		Name varchar(100) NOT NULL,
		Description varchar(1000),
		Status varchar (20) NOT NULL,
		CreatedOn datetime
		)
```
3. Build solution and if you need exe file, you can publish solution and generate working file

## Usage
1. Using Add task button you can add new task to do.
2. If you want to modify exsisting task double click your task and form will be shown.
3. With red button in right corner you can delete task if you don't need it anymore.
4. Reload button will refresh all task for an example if you modify record in database directly
