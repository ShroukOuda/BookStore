namespace BookStore.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IAuthorsService _authorsService;

        public AuthorsController(IAuthorsService authorsService)
        {
            _authorsService = authorsService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var authors = _authorsService.GetAllAuthors();
            return View(authors);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new AuthorFormViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(AuthorFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);
            _authorsService.Create(viewModel);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var author = _authorsService.GetAuthorById(id);

            if (author is null)
                return NotFound();

            AuthorFormViewModel viewModel = new()
            {
                Id = id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Biography = author.Biography,
                BirthDate = author.BirthDate,
                DeathDate = author.DeathDate,
                Nationality = author.Nationality
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Update(AuthorFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            var author = _authorsService.Update(viewModel);
            if (author is null)
                return BadRequest();

            return RedirectToAction(nameof(Index));
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var isDeleted = _authorsService.Delete(id);

            if (isDeleted)
                return Ok();
            
            return BadRequest();
        }
    }
}
