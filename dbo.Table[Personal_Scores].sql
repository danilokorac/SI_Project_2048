CREATE TABLE [dbo].[Personal_Scores]
(
	[PlayerID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Score] INT NOT NULL, 
    [DateAndTime] DATE NOT NULL, 
    [NumberOfMoves] INT NOT NULL, 
    [TimePlayed] TIME(6) NOT NULL, 
    CONSTRAINT [FK_Personal_Scores_Players] FOREIGN KEY ([PlayerID]) REFERENCES [Players]([PlayerID])
)
