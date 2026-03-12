CREATE TABLE [dbo].[Order]
(
	[OrderCode] INT NOT NULL PRIMARY KEY, 
    [OrderDate] DATETIME NULL, 
    [Employee] NVARCHAR(50) NULL
)
