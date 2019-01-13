CREATE TABLE [dbo].[Employe] (
    [EmployeUid]         UNIQUEIDENTIFIER NOT NULL,
    [RegistrationNumber] INT              NOT NULL,
    [Name]               NVARCHAR (50)    NOT NULL,
    [FirstName]          NVARCHAR (50)    NOT NULL,
    [Adress]             NVARCHAR (MAX)   NULL,
    [Phone]              INT              NOT NULL,
    [Email]              NVARCHAR (50)    NULL,
    [EmploymentId]       INT              NOT NULL,
    [CreatedDate]        DATETIME         NULL,
    [CreatedBy]          NVARCHAR (MAX)   NULL,
    [UpdatedDate]        DATETIME         NULL,
    [UpdatedBy]          NVARCHAR (MAX)   NULL,
    PRIMARY KEY CLUSTERED ([RegistrationNumber] ASC),
    CONSTRAINT [FK_Employe_Employment] FOREIGN KEY ([EmploymentId]) REFERENCES [dbo].[Employment] ([EmploymentId])
);

