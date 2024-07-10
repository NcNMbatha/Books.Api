CREATE TABLE Books(
	Id INT IDENTITY PRIMARY KEY,
	Title NVARCHAR(200) NOT NULL,
	Author NVARCHAR(200) NOT NULL,
	ISBN NVARCHAR(30),
	Genre VARCHAR(50),
	ShortDescriptrion TEXT,
	Price DECIMAL
)

