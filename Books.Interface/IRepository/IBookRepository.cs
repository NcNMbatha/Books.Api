using Books.Model;
using System.Data;

namespace Books.Interface.IRepository
{
    public interface IBookRepository
    {
        Task<int> CreateBookAsync(Book book);

        Task<Book> GetBookByIdAsync(int id);

        Task<IEnumerable<Book>> GetAllBooksAsync();

        Task<int> UpdateBookAsync(Book book);

        Task<int> DeleteBookAsync(int id);
        
    }
}
