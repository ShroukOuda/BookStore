namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly ICategoriesService _categoriesService;

        private readonly IAuthorsService _authorsService;

        private readonly IBooksService _booksService;
        public BooksController(ICategoriesService categoriesService, IAuthorsService authorsService, IBooksService booksService)
        {
            _categoriesService = categoriesService;
            _authorsService = authorsService;
            _booksService = booksService;
        }

        [HttpGet]
        public IActionResult Index(BookFilterViewModel filter)
        {
            var books = _booksService.GetFilteredBooks(filter);
            filter.Books = books;
            
            ViewBag.Categories = _categoriesService.GetSelectList();
            ViewBag.Authors = _authorsService.GetSelectList();
            
            return View(filter);
        }

        [HttpGet]
        public IActionResult GetBookDetail(int id)
        {
            var book = _booksService.GetBookDetail(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        
        
        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new CreateBookFromViewModel
            {
                Categories = _categoriesService.GetSelectList(),

                Authors = _authorsService.GetSelectList()

            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateBookFromViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Categories = _categoriesService.GetSelectList();

                viewModel.Authors = _authorsService.GetSelectList();

                return View(viewModel);

            }

            _booksService.Create(viewModel);

            return RedirectToAction(nameof(Index));
        
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var  book = _booksService.GetBookDetail(id);

            if (book is null)
                return NotFound();

            UpdateBookFromViewModel viewModel = new()
            {
                Id = id,
                ISBN = book.ISBN,
                Title = book.Title,
                Description = book.Description,
                Price = book.Price,
                StockQuantity = book.StockQuantity,
                PublishedDate = book.PublishedDate,
                Pages = book.Pages,
                Language = book.Language,
                CategoryId = book.CategoryId,
                SelectedAuthors = book.BookAuthors.Select(ba => ba.AuthorId).ToList(),
                Categories = _categoriesService.GetSelectList(),
                Authors = _authorsService.GetSelectList(),
                CurrentImage = book.ImageUrl
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(UpdateBookFromViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = _categoriesService.GetSelectList();

                model.Authors = _authorsService.GetSelectList();

                return View(model);

            }
            
            var book = _booksService.Update(model);

            if (book is null)
                return BadRequest();

            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var isDeleted = _booksService.Delete(id);

            if (isDeleted)
                return Ok();
            return BadRequest();
        }
    }
}
