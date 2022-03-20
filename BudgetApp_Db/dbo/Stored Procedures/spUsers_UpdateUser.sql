CREATE PROCEDURE [dbo].[spUsers_UpdateUser]
	@ID INT,
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE Users
	SET FirstName = @FirstName, LastName = @LastName
	WHERE ID = @ID
END