CREATE TABLE [dbo].[Users]
(
	[UserId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] NVARCHAR(30) NOT NULL, 
    [Password] NVARCHAR(30) NOT NULL, 
    [LoyaltyPoints] INT NOT NULL
)
