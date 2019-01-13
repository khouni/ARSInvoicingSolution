CREATE TABLE [dbo].[Currency] (
    [CurrencyUid] INT            NOT NULL,
    [CurrencyId]  INT            NOT NULL,
    [Name]        NVARCHAR (50)  NOT NULL,
    [CreatedDate] DATETIME       NULL,
    [CreatedBy]   NVARCHAR (MAX) NULL,
    [UpdatedDate] DATETIME       NULL,
    [UpdatedBy]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK__Currency] PRIMARY KEY CLUSTERED ([CurrencyId] ASC)
);

