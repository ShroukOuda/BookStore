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

		public IActionResult Index()
		{
			var books = _booksService.GetAllBooks();
			return View(books);
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
    }
}
