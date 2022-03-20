CREATE PROCEDURE [dbo].[spUsers_InsertUser]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Users(FirstName,LastName)
	VALUES(@FirstName,@LastName)
END