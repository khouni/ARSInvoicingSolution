CREATE TABLE [dbo].[InterventionType] (
    [InterventionTypeUid] UNIQUEIDENTIFIER NOT NULL,
    [InterventionTypeId]  INT              NOT NULL,
    [Name]                NVARCHAR (50)    NOT NULL,
    [Description]         NVARCHAR (MAX)   NULL,
    [CreatedDate]         DATETIME         NULL,
    [CreatedBy]           NVARCHAR (MAX)   NULL,
    [UpdatedDate]         DATETIME         NULL,
    [UpdatedBy]           NVARCHAR (MAX)   NULL,
    PRIMARY KEY CLUSTERED ([InterventionTypeId] ASC)
);

