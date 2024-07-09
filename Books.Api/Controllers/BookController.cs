using Books.Interface.IService;
using Books.Model;
using Microsoft.AspNetCore.Mvc;

namespace Books.Api.Controllers
{
    [ApiController]
    [Route("[api/books]")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly ILogger<BookController> _logger;

        public BookController(IBookService bookService, ILogger<BookController> logger)
        {
            _bookService = bookService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] Book book)
        {
            return Ok(await _bookService.CreateBookAsync(book));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            return Ok(await _bookService.GetBookByIdAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            return Ok(await _bookService.GetAllBooksAsync());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] Book book)
        {
            return Ok(await _bookService.UpdateBookAsync(book));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            return Ok(await _bookService.DeleteBookAsync(id));
        }
    }
}
