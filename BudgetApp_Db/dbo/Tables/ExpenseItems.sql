CREATE TABLE [dbo].[ExpenseItems]
(
	[ID] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonID] INT NOT NULL, 
    [ExpenseCategory_ID] INT NOT NULL, 
    [ExpenseSubCategory_ID] INT NOT NULL, 
    [Amount] MONEY NOT NULL DEFAULT 0, 
    [TimeStamp] DATETIME2 NOT NULL, 
    [IsReOccurring] BIT NOT NULL, 
    [BudgetFrequency] INT NOT NULL, 
    [ReferenceNumber] NVARCHAR(50) NULL, 
    [Note] NVARCHAR(50) NULL
)
