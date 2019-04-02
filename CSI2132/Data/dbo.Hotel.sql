CREATE TABLE [dbo].[Hotel] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [ParentChain] NVARCHAR(MAX) NULL,
    [Rating]  INT NULL DEFAULT 3,
	[NumberOfRooms] INT NULL ,
    [Address] NVARCHAR(MAX) NULL,
    [PhoneNumber] NVARCHAR(MAX) NULL,
    [Email] NVARCHAR(MAX) NULL,
    CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED ([Id] ASC)

);

