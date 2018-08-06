CREATE TABLE [dbo].[ActiveBookings]
(
	[BookingId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [SuiteId] INT NOT NULL, 
    [CheckInDate] DATE NOT NULL, 
    [StayDuration] INT NOT NULL
)
