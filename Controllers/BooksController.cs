using Microsoft.AspNetCore.Mvc;

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
			return View();
		}
	}
}
