CREATE TABLE [dbo].[Favourites]
(
	[FavouritesId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [SuiteId] INT NOT NULL
)
