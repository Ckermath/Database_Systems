CREATE TABLE [DBO].[Employee]
(
EmployeeNo int PRIMARY KEY, 
EmployeeName varchar(50) NOT NULL,
DepartmentNo int NOT NULL,
Foreign Key ([DepartmentNO]) References [Department]([DepartmentNo]))