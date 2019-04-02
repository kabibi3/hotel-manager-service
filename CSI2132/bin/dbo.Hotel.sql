CREATE TABLE [dbo].[Hotel] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Rating]        INT            NOT NULL,
    [NumberOfRooms] INT            NOT NULL,
    [Address]       NVARCHAR (MAX) NULL,
    [PhoneNumber]   NVARCHAR (MAX) NULL,
    [Email]         NVARCHAR (MAX) NULL,
    [ParentChain] NVARCHAR(MAX) NULL, 
    CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED ([Id] ASC)
);

