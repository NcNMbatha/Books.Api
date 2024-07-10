CREATE PROCEDURE sp_CreateBook
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
    INSERT INTO Books (Title, Author, PublicationDate,Price, ShortDescription, @ISBN, @Genre, @Price)
    VALUES (@Title, @Author, @PublicationDate, @ShortDescription, @ISBN, @Genre, @Price)
END
GO

