CREATE PROCEDURE sp_UpdateBook
    @Id INT,
    @Title NVARCHAR(200),
    @Author NVARCHAR(150),
    @PublicationDate DATETIME,
	@ShortDescription TEXT,
	@ISBN NVARCHAR(30),
	@Genre VARCHAR(50),
	@Price NVARCHAR(50)
AS
BEGIN
UPDATE Books
	SET Title = @Title, 
		Author = @Author, 
		PublicationDate = @PublicationDate,
		ShortDescription = @ShortDescription,
		ISBN = @ISBN,
		Genre = @Genre,
		Price = @Price
	WHERE Id = @Id
END
GO