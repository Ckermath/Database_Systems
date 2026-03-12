CREATE TABLE [DBO].[ProjectEmployee]
(
ProjectCode int,
EmployeeNo int,
HourlyRate decimal(4,2) NOT NULL,
Primary Key([Projectcode],[EmployeeNo]),
Foreign Key ([ProjectCode]) References [Project],
Foreign Key ([EmployeeNo]) References [Employee])