namespace BookStore.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ApplicationDbContext _context;

        public CategoriesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetSelectList()
        {
            return _context.Categories
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                })
                .OrderBy(c => c.Text)
                .ToList();
        }

        public IEnumerable<CategoryViewModel> GetAllCategories()
        {
            return _context.Categories
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt,
                    BookCount = c.Books.Count()
                })
                .ToList();
        }

        public Category GetCategoryDetails(int id)
        {
            return _context.Categories.Find(id);
        }

        public void CreateCategory(CategoryFormViewModel model)
        {
            Category category = new()
            {
                Name = model.Name,
                Description = model.Description,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _context.Add(category);
            _context.SaveChanges();
        }

        public Category UpdateCategory(CategoryFormViewModel model)
        {
            var category = _context.Categories.Find(model.Id);

            if (category is null)
                return null;
            category.Name = model.Name;
            category.Description = model.Description;
            category.UpdatedAt = DateTime.Now;
            
            _context.SaveChanges();
            return category;
        }

        public bool DeleteCategory(int id)
        {
            bool isDeleted = false;

            var category = _context.Categories
                .Include(b => b.Books)
                .FirstOrDefault(c => c.Id == id);

            if (category is null)
                return isDeleted;
            
            _context.Remove(category);
            _context.SaveChanges();
            
            return isDeleted;
        }
    }
}
