CREATE TABLE [dbo].[Suites]
(
	[SuiteId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RoomNumber] NVARCHAR(10) NOT NULL, 
    [Floor] NVARCHAR(10) NOT NULL, 
    [RoomType] NVARCHAR(20) NOT NULL, 
    [NumberOfBedrooms] INT NOT NULL, 
    [NumberOfBathrooms] INT NOT NULL, 
    [NightlyRate] FLOAT NOT NULL, 
    [IsAvailable] BIT NOT NULL, 
    [ThumbnailURL] NVARCHAR(20) NOT NULL, 
    [HotelId] INT NOT NULL
)
