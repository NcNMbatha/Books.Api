CREATE PROCEDURE sp_CreateBook
    @Title NVARCHAR(200),
    @Author NVARCHAR(150),
    @PublicationDate DATETIME,
	@ShortDescription TEXT,
	@ISBN NVARCHAR(30),
	@Genre VARCHAR(50),
	@Price NVARCHAR(50)
AS
BEGIN
    INSERT INTO Books (Title, Author, ISBN, Genre, PublicationDate, ShortDescriptrion, Price)
    VALUES (@Title, @Author, @ISBN, @Genre, @PublicationDate, @ShortDescription,  @Price)
END
GO

