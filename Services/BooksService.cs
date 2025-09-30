using BookStore.Settings;
using Microsoft.IdentityModel.Tokens;

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
            _imagesPath = $"{_webHostEnvironment.WebRootPath}{FileSettings.ImagesPath}";

        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books
                .Include(b => b.Category)
                .Include(b => b.BookAuthors)
                    .ThenInclude(ba => ba.Author)
                .ToList();
        }

        public Book GetBookDetail(int id)
        {
            return _context.Books
                .Include(b => b.Category)
                .Include(b => b.BookAuthors)
                    .ThenInclude(ba => ba.Author)
                .FirstOrDefault(b => b.Id == id);
        }
        
        
        public IEnumerable<Book> GetFilteredBooks(BookFilterViewModel filter)
        {
            var query = _context.Books
                .Include(b => b.Category)
                .Include(b => b.BookAuthors)
                  .ThenInclude(ba => ba.Author)
                .AsQueryable();

            if (filter.CategoryId.HasValue)
            {
                query = query.Where(b => b.CategoryId == filter.CategoryId);
            }

            if (filter.AuthorId.HasValue)
            {
                query = query.Where(b => b.BookAuthors.Any(ba => ba.AuthorId == filter.AuthorId));
            }

            if (!filter.Language.IsNullOrEmpty())
            {
                query = query.Where(b => b.Language == filter.Language);
            }

            if (filter.MinPrice.HasValue)
            {
                query = query.Where(b => b.Price >= filter.MinPrice);
            }

            if (filter.MaxPrice.HasValue)
            {
                query = query.Where(b => b.Price <= filter.MaxPrice);
            }

            if (filter.MinPages.HasValue)
            {
                query = query.Where(b => b.Pages >= filter.MinPages);
            }

            if (filter.MaxPages.HasValue)
            {
                query = query.Where(b => b.Pages <= filter.MaxPages);
            }

            if (!string.IsNullOrWhiteSpace(filter.SearchQuery))
            {
                filter.SearchQuery = filter.SearchQuery.Trim().ToLower();

                query = query.Where(b => 
                    b.Title.ToLower().Contains(filter.SearchQuery) ||
                    b.ISBN.Contains(filter.SearchQuery));
            }

            return query.ToList();
        }


        public void Create(CreateBookFromViewModel model)
        {
            var imageName = SaveImage(model.ImageUrl);

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

        public Book Update(UpdateBookFromViewModel model)
        {
            var book = _context.Books
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .FirstOrDefault(b => b.Id == model.Id);

            if (book is null)
                return null;

            var hasNewImage = model.ImageUrl is not null;
            var oldImage = book.ImageUrl;
            
            book.ISBN = model.ISBN;
            book.Title = model.Title;
            book.Description = model.Description;
            book.Price = model.Price;
            book.StockQuantity = model.StockQuantity;
            book.PublishedDate = model.PublishedDate;
            book.Pages = model.Pages;
            book.Language = model.Language;
            book.CategoryId = model.CategoryId;
            book.BookAuthors = model.SelectedAuthors.Select(authorId => new BookAuthor
            {
                AuthorId = authorId
            }).ToList();

            book.UpdatedAt = DateTime.UtcNow;

            if (hasNewImage)
            {
                book.ImageUrl = SaveImage(model.ImageUrl!);
            }
            
            var effectedRows =  _context.SaveChanges();

            if (effectedRows > 0)
            {
                if (hasNewImage)
                {
                    var image = Path.Combine(_imagesPath, oldImage);
                    File.Delete(image);
                }

                return book;
            }

            else
            {
                var image = Path.Combine(_imagesPath, book.ImageUrl);
                File.Delete(image);

                return null;
            }
        }

        public bool Delete(int id)
        {
            var isDeleted = false;
            var book = _context.Books
                .Include(ba => ba.BookAuthors)
                .FirstOrDefault(b => b.Id == id);
                

            if (book is null)
                return isDeleted;
            
            
            _context.Remove(book);

            var effectedRows = _context.SaveChanges();

            if (effectedRows > 0)
            {
                isDeleted = true;

                var image = Path.Combine(_imagesPath, book.ImageUrl);
                File.Delete(image);
            }

            return isDeleted;   
        }

        private string SaveImage(IFormFile Image)
        {
            var imageName = $"{Guid.NewGuid()}{Path.GetExtension(Image.FileName)}";

            var imagePath = Path.Combine(_imagesPath, imageName);

            using var stream = File.Create(imagePath);
            Image.CopyTo(stream);

            return imageName;
        }
    }
    
}
