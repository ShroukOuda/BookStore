using BookStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStore.Controllers
{
	public class BooksController : Controller
	{
		private readonly ApplicationDbContext _context;
        public BooksController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var books = _context.Books
				.Include(c => c.Category)
				.Include(b => b.BookAuthors)
					.ThenInclude(ba => ba.Author)
				.ToList();
			return View(books);
		}

		[HttpGet]
		public IActionResult Create()
		{
            var viewModel = new CreateBookFromViewModel
            {
                Categories = _context.Categories.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                })
				.OrderBy(c => c.Text)
                .ToList(),

                Authors = _context.Authors.Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.FullName
                }),
                Pages = 0,
                StockQuantity = 0,
                PublishedDate = DateTime.Now
            };

            return View(viewModel);
		}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateBookFromViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}
