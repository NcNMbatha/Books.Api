using Books.Interface.IRepository;
using Books.Model;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Books.Repository
{
    public class BookRepository:IBookRepository
    {
        private readonly string _connectionString;

        public BookRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public async Task<int> CreateBookAsync(Book book)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Title", book.Title);
                parameters.Add("@Author", book.Author);
                parameters.Add("@Text", book.Text);
                parameters.Add("@Year", book.Year);
                parameters.Add("@Price", book.Price);

                var result = await connection.ExecuteAsync("sp_CreateBook", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                var book = await connection.QueryFirstOrDefaultAsync<Book>("sp_GetBookById", parameters, commandType: CommandType.StoredProcedure);
                
                return book;
            }
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            using (var connection = CreateConnection())
            {
                var books = await connection.QueryAsync<Book>("sp_GetAllBooks", commandType: CommandType.StoredProcedure);
                return books;
            }
        }

        public async Task<int> UpdateBookAsync(Book book)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Title", book.Title);
                parameters.Add("@Author", book.Author);
                parameters.Add("@Text", book.Text);
                parameters.Add("@Year", book.Year);
                parameters.Add("@Price", book.Price);

                var result = await connection.ExecuteAsync("sp_UpdateBook", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<int> DeleteBookAsync(int id)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", id);

                var result = await connection.ExecuteAsync("sp_DeleteBook", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

    }
}
