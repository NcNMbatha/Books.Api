CREATE PROCEDURE sp_GetAllBooks
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
	FROM Books
END
GO