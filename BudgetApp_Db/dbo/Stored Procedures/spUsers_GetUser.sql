CREATE PROCEDURE [dbo].[spUsers_GetUser]
	@ID int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT FirstName, LastName
	FROM Users
	WHERE ID = @ID;
END