CREATE TABLE [dbo].[Hotels]
(
	[HotelId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [HotelName] NVARCHAR(30) NOT NULL, 
    [CountryId] INT NOT NULL
)
