CREATE TABLE [dbo].[ProjectEmployee] (
    [ProjectCode] INT            NOT NULL,
    [EmployeeNo]  INT            NOT NULL,
    [HourlyRate]  DECIMAL (4, 2) NULL,
    PRIMARY KEY CLUSTERED ([ProjectCode] ASC, [EmployeeNo] ASC),
    FOREIGN KEY ([EmployeeNo]) REFERENCES [dbo].[Employee] ([EmployeeNo]),
    FOREIGN KEY ([ProjectCode]) REFERENCES [dbo].[Project] ([ProjectCode])
);

