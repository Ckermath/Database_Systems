CREATE TABLE [dbo].[Project] (
    [ProjectCode]      INT     IDENTITY(1,1)        NOT NULL,
    [ProjectTitle]     VARCHAR (50)    NOT NULL,
    [ProjectManager]   VARCHAR (50)    NOT NULL,
    [ProjectBudget]    DECIMAL (18, 2) NOT NULL,
    [ProjectStartDate] DATE            NULL,
    [ProjectEndDate]   DATE            NULL,
    [ProjectCompleted] BIT             NULL,
    PRIMARY KEY CLUSTERED ([ProjectCode] ASC)
);

