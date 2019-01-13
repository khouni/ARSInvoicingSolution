CREATE TABLE [dbo].[Employment] (
    [EmploymentUid] UNIQUEIDENTIFIER NOT NULL,
    [EmploymentId]  INT              NOT NULL,
    [Name]          NVARCHAR (50)    NOT NULL,
    [Description]   NVARCHAR (MAX)   NULL,
    [CreatedDate]   DATETIME         NULL,
    [CreatedBy]     NVARCHAR (MAX)   NULL,
    [UpdatedDate]   DATETIME         NULL,
    [UpdatedBy]     NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK__Employment] PRIMARY KEY CLUSTERED ([EmploymentId] ASC)
);

