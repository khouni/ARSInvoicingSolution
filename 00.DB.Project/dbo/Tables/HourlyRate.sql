CREATE TABLE [dbo].[HourlyRate] (
    [HourlyRateUid]      INT             NOT NULL,
    [HourlyRateId]       INT             NOT NULL,
    [CustomerTypeId]     INT             NOT NULL,
    [InterventionTypeId] INT             NOT NULL,
    [CurrencyId]         INT             NOT NULL,
    [PriceWithoutTaxe]   DECIMAL (18, 3) NOT NULL,
    [CreatedDate]        DATETIME        NULL,
    [CreatedBy]          NVARCHAR (MAX)  NULL,
    [UpdatedDate]        DATETIME        NULL,
    [UpdatedBy]          NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK__HourlyRate] PRIMARY KEY CLUSTERED ([HourlyRateId] ASC),
    CONSTRAINT [FK_HourlyRate_Currency] FOREIGN KEY ([CurrencyId]) REFERENCES [dbo].[Currency] ([CurrencyId]),
    CONSTRAINT [FK_HourlyRate_CustomerType] FOREIGN KEY ([CustomerTypeId]) REFERENCES [dbo].[CustomerType] ([CustomerTypeTypeId]),
    CONSTRAINT [FK_HourlyRate_HourlyRate] FOREIGN KEY ([HourlyRateId]) REFERENCES [dbo].[HourlyRate] ([HourlyRateId]),
    CONSTRAINT [FK_HourlyRate_InterventionType] FOREIGN KEY ([InterventionTypeId]) REFERENCES [dbo].[InterventionType] ([InterventionTypeId])
);

