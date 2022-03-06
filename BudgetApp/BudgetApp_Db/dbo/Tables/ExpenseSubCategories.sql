CREATE TABLE [dbo].[ExpenseSubCategories]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ExpenseCategory_ID] INT NOT NULL, 
    [Name] NCHAR(10) NOT NULL
)
