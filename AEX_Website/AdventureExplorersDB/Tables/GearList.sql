CREATE TABLE [dbo].[GearList] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Gear]        NVARCHAR (50) NOT NULL,
    [Model]       NVARCHAR (60) NULL,
    [DateOut]     DATETIME      NULL,
    [DateIn]      DATETIME      NULL,
    [CheckOutBy]  NVARCHAR (50) NULL,
    [CreatedDate] DATETIME      DEFAULT (getutcdate()) NOT NULL,
    [UpdatedDate] DATETIME      NULL,
    [isActive]    BIT           DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

