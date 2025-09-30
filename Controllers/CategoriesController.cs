using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesService _categoriesService;
        private readonly IBooksService _booksService;
        public CategoriesController(ICategoriesService categoriesService, IBooksService booksService)
        {
            _categoriesService = categoriesService;
            _booksService = booksService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var categories = _categoriesService.GetAllCategories();
            return View(categories);
        }
        

     

        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new CategoryFormViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CategoryFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            
            _categoriesService.CreateCategory(viewModel);
            
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var category = _categoriesService.GetCategoryDetails(id);

            if (category is null)
                return NotFound();

            CategoryFormViewModel viewModel = new()
            {
                Id = id,
                Name = category.Name,
                Description = category.Description
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Update(CategoryFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            var category = _categoriesService.UpdateCategory(viewModel);

            if (category is null)
                return BadRequest();

            return RedirectToAction(nameof(Index));
        }
        
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var isDeleted = _categoriesService.DeleteCategory(id);

            if (isDeleted)
                return Ok();
            return BadRequest();
        }
        
    }
}
