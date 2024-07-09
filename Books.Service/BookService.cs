using Books.Interface.IRepository;
using Books.Interface.IService;
using Books.Model;

namespace Books.Service
{
    public class BookService:IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<int> CreateBookAsync(Book book)
        {
            return await _bookRepository.CreateBookAsync(book);
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _bookRepository.GetBookByIdAsync(id);
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        { 
            return await _bookRepository.GetAllBooksAsync();
        }

        public async Task<int> UpdateBookAsync(Book book)
        {
            return await _bookRepository.UpdateBookAsync(book);
        }

        public async Task<int> DeleteBookAsync(int id)
        {
            return await _bookRepository.DeleteBookAsync(id);
        }
    }
}
