CREATE TABLE [dbo].[Achievements]
(
	[PlayerID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CompletedGame] BIT NULL, 
    [BetterThanAverageMoves] BIT NULL, 
    [BetterThanAverageTime] BIT NULL, 
    CONSTRAINT [FK_Achievements_Personal_Scores] FOREIGN KEY ([PlayerID]) REFERENCES [Personal_Scores]([PlayerID])
)
