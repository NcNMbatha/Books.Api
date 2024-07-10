CREATE PROCEDURE sp_GetBookById
    @Id INT
AS
BEGIN
    SELECT Id, 
	       Title, 
		   Author, 
		   ISBN, 
		   Genre, 
		   PublicationDate,
		   ShortDescription, 
		   Price
	FROM Books WHERE Id = @Id
END
GO