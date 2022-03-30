CREATE TABLE [dbo].[IncomeItems]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [UserID] INT NOT NULL, 
    [IncomeCategory_ID] INT NOT NULL, 
    [Amount] MONEY NOT NULL DEFAULT 0, 
    [TimeStamp] DATETIME2 NOT NULL, 
    [IsReOccuring] BIT NOT NULL, 
    [BudgetFrequency] INT NOT NULL, 
    [Note] NVARCHAR(50) NULL
)
