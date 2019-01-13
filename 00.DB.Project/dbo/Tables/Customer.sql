CREATE TABLE [dbo].[Customer] (
    [CustomerUid]           UNIQUEIDENTIFIER NOT NULL,
    [TaxRegistrationNumber] NVARCHAR (50)    NOT NULL,
    [TradeRegister]         NVARCHAR (50)    NOT NULL,
    [SocialReason]          NVARCHAR (50)    NOT NULL,
    [Adress]                NVARCHAR (MAX)   NULL,
    [Phone]                 INT              NULL,
    [Email]                 NVARCHAR (50)    NULL,
    [TypeId]                INT              NOT NULL,
    [CreatedDate]           DATETIME         NULL,
    [CreatedBy]             NVARCHAR (MAX)   NULL,
    [UpdatedDate]           DATETIME         NULL,
    [UpdatedBy]             NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK__Client] PRIMARY KEY CLUSTERED ([TaxRegistrationNumber] ASC),
    CONSTRAINT [FK_Customer_CustomerType] FOREIGN KEY ([TypeId]) REFERENCES [dbo].[CustomerType] ([CustomerTypeTypeId])
);

