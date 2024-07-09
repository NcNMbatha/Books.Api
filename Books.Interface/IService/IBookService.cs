using Books.Model;

namespace Books.Interface.IService
{
    public interface IBookService
    {
        Task<int> CreateBookAsync(Book book);

        Task<Book> GetBookByIdAsync(int id);

        Task<IEnumerable<Book>> GetAllBooksAsync();

        Task<int> UpdateBookAsync(Book book);

        Task<int> DeleteBookAsync(int id);
    }
}
