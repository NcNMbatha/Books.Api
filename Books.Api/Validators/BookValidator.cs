using Books.Model;
using FluentValidation;

namespace Books.Api.Validators
{
    public class BookValidator: AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(book => book.Id).GreaterThan(0);
            RuleFor(book => book.Title).NotEmpty().WithMessage("Title is required.");
            RuleFor(book => book.Author).NotEmpty().WithMessage("Author is required.");
            RuleFor(book => book.PublicationDate).NotEmpty().LessThanOrEqualTo(DateTime.Now);
            RuleFor(book => book.ISBN).NotEmpty().Length(10, 13);
            RuleFor(book => book.Genre).NotEmpty();
            RuleFor(book => book.ShortDescription).NotEmpty();
            RuleFor(book => book.Price).GreaterThan(0);
        }
        
    }
}
