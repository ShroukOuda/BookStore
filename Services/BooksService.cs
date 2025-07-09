namespace BookStore.Services
{
    public class BooksService : IBooksService
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _webHostEnvironment;

        private readonly string _imagesPath;
        public BooksService(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _imagesPath = $"{_webHostEnvironment.WebRootPath}/images/books";

        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books
                .Include(b => b.Category)
                .Include(b => b.BookAuthors)
                    .ThenInclude(ba => ba.Author)
                .ToList();
        }

        public void Create(CreateBookFromViewModel model)
        {
            var imageName = $"{Guid.NewGuid()}{Path.GetExtension(model.ImageUrl.FileName)}";

            var imagePath = Path.Combine(_imagesPath, imageName);

            using var stream = File.Create(imagePath);
            model.ImageUrl.CopyTo(stream);

            Book book = new()
            {
                ISBN = model.ISBN,
                Title = model.Title,
                Description = model.Description,
                Price = model.Price,
                StockQuantity = model.StockQuantity,
                ImageUrl = imageName,
                PublishedDate = model.PublishedDate,
                Pages = model.Pages,
                Language = model.Language,
                CategoryId = model.CategoryId,
                BookAuthors = model.SelectedAuthors.Select(authorId => new BookAuthor
                {
                    AuthorId = authorId
                }).ToList(),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow

            };

            _context.Add(book);
            _context.SaveChanges();
        }
    }
    
}
