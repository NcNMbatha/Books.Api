using Books.Interface.IService;
using Books.Model;
using Microsoft.AspNetCore.Mvc;

namespace Books.Api.Controllers
{
    [ApiController]
    [Route("api/book")]
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
        [Route("create-book")]
        public async Task<IActionResult> CreateBook([FromBody] Book book)
        {
            return Ok(await _bookService.CreateBookAsync(book));
        }

        [HttpGet]
        [Route("get-book")]
        public async Task<IActionResult> GetBookById(int id)
        {
            return Ok(await _bookService.GetBookByIdAsync(id));
        }

        [HttpGet]
        [Route("get-books")]
        public async Task<IActionResult> GetAllBooks()
        {
            return Ok(await _bookService.GetAllBooksAsync());
        }

        [HttpPut]
        [Route("update-book")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] Book book)
        {
            return Ok(await _bookService.UpdateBookAsync(book));
        }

        [HttpDelete]
        [Route("delete-book")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            return Ok(await _bookService.DeleteBookAsync(id));
        }
    }
}
