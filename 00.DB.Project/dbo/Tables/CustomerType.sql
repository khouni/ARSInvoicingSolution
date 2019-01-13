CREATE TABLE [dbo].[CustomerType] (
    [CustomerTypeTypeUid] UNIQUEIDENTIFIER NOT NULL,
    [CustomerTypeTypeId]  INT              NOT NULL,
    [Description]         NVARCHAR (50)    NULL,
    [CreatedDate]         DATETIME         NULL,
    [CreatedBy]           NVARCHAR (MAX)   NULL,
    [UpdatedDate]         DATETIME         NULL,
    [UpdatedBy]           NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK__Customer__CustomerType] PRIMARY KEY CLUSTERED ([CustomerTypeTypeId] ASC)
);

