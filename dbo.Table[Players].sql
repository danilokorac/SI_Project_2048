CREATE TABLE [dbo].[Players]
(
	[PlayerID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [IGN (In Game Name)] NVARCHAR(50) NOT NULL
)
