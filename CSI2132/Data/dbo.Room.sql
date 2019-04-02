CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Price] DECIMAL NULL, 
    [Amenities] NVARCHAR(MAX) NULL, 
    [Capacity] NVARCHAR(MAX) NULL, 
    [Extendible] BIT NULL, 
    [Damages] BIT NULL, 
    [View] NVARCHAR(MAX) NULL
)
