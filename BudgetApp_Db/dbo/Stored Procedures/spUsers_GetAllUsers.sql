CREATE PROCEDURE [dbo].[spUsers_GetAllUsers]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT ID,FirstName,LastName
	FROM Users
END